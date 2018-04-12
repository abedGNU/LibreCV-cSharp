using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HalconDotNet;

namespace OCR
{
    public class OCR //: HOCRMlp
    {
        //
        #region Variables

        HOCRMlp ocrMlp;
        HTextModel textModel;
        string mode = "manual"; // "auto" or "manual"

        #region directories and file names

        public string mlpFileExtension = ".omc";
        public string trainFileExtension = ".trf";
        public string directory = @"dataRep\Vision\Models\OCR\";

        public string fontName = "classifierMlp";
        public string trainFile = "testTrainFile";

        #endregion //directories and file names

        public HImage image, segImage;
        public int imgH, imgW;
        public HRegion regionsSegmented;
        public double minGray = 140;
        public double maxGray = 255;

        public int dilationH = 40;
        public int dilationW = 3;

        #endregion //variables


        #region Constructors
        /*
        public OCR(string mode, string fontFile)
        {
            //this.fontFile = fontFile;
            this.mode = mode;
            //ReadOcrClass();
        }*/

        public OCR()
        {
            image = new HImage();
            ocrMlp = new HOCRMlp();
            textModel = new HTextModel();
        }

        #endregion // Constructors

        #region Classifier

        public void ReadOcrClass()
        {
            ocrMlp = new HOCRMlp();
            string fontFile = directory + fontName + mlpFileExtension;
            HOperatorSet.FileExists(fontFile, out HTuple fileExists);
            // add control on fileexist
            if (fileExists = 1)
            {
                ocrMlp.ReadOcrClassMlp(fontFile);
                //textModel.CreateTextModelReader(mode, fontFile);
            }
        }

        public HTuple ClassifyMulti()
        {
            HTuple confidence;
            ReadOcrClass();
            return ocrMlp.DoOcrMultiClassMlp(SegmentImage(), image, out confidence);
        }

        public void CreateTrainingFile( HObject region, HImage img, string Class )
        {
            
            //HRegion region, selectedRegion;
            string trainfile = directory + trainFile+ trainFileExtension;
           // region = img.Threshold(100.0, 255).Connection().SortRegion("character", "true", "row");
            // for object, the index start from 1.
            //selectedRegion = region.SelectObj(1);
            HOperatorSet.AppendOcrTrainf(region, img, Class, trainfile);
  

        }

        public HRegion GetSortedRegions(HImage img)
        {
            return img.Threshold(100.0, 255).Connection().SortRegion("character", "true", "row");
        }

        /*
        public HRegion[] getCharRegions(HImage img)

        {
            
            HRegion region;
            region = img.Threshold(100.0, 255).Connection().SortRegion("character", "true", "row");
            HRegion[] regions= new HRegion[region.CountObj()];

            for (int i = 0; i < region.CountObj(); i++)
            {
                // for object, the index start from 1.
                regions[i] = region.SelectObj(i+1);
            }
            return regions;
        }*/

        public void AppendOcrTrainf(HImage img, HRegion region, string charName )
        {

           // HRegion region, selectedRegion;
            string trainfile = directory + trainFile + trainFileExtension;
           // region = img.Threshold(100.0, 255).Connection().SortRegion("character", "true", "row");
            // for object, the index start from 1.
            //selectedRegion = region.SelectObj(1);
            HOperatorSet.AppendOcrTrainf(region, img, charName, trainfile);
        }

        public void trainClassifier()
        {
            string trainfile = directory + trainFile + trainFileExtension;
            string fontFile = directory + fontName + mlpFileExtension;
            HTuple charNames, charCount, ErrorLog;
            int NumHidden = 20;
            HOperatorSet.ReadOcrTrainfNames(trainfile, out charNames, out charCount);
            ocrMlp.CreateOcrClassMlp(8, 10, "constant", "default", charNames, NumHidden, "none", 1, 42);
            ocrMlp.TrainfOcrClassMlp(trainfile, 200, 1, 0.01, out ErrorLog);
            ocrMlp.WriteOcrClassMlp(fontFile);
        }

        #endregion // classifier

        #region Image processing

        public HImage SegmentImage()
        {
            HRegion region, connectedRegions, selectedRegions, SortedRegions;
            HRegion regionDilated, tmpRegion;
            HImage imgReduced;
            HTuple row1, row2;
            HTuple col1, col2;

            region = image.Threshold(minGray, maxGray);

            regionDilated = region.Connection().DilationRectangle1(dilationH, dilationW);
            selectedRegions = regionDilated.SelectShape(new HTuple("area", "row"), "and", new HTuple(2000, 400), new HTuple(60000, 2200));
            connectedRegions = selectedRegions.Union1().Connection();
            connectedRegions.SmallestRectangle1(out row1, out col1, out row2, out col2);
            tmpRegion = new HRegion();
            tmpRegion.GenRectangle1(row1, col1, row2, col2);
            imgReduced = image.ReduceDomain(tmpRegion.Union1());

            region = imgReduced.Threshold(12.0, 255.0);
            selectedRegions = region.Connection().SelectShape("area", "and", 1000, 6000);
            imgReduced.GetImageSize(out imgH, out imgW);
            segImage = selectedRegions.ClosingRectangle1(8, 3).Union1().RegionToBin(255, 0, imgH, imgW);

            //SortedRegions = selectedRegions.SortRegion("character", "true", "row");
            return segImage;

        }// HImage SegmentImage()

        public void alignImage()
        {

        }

        #endregion // image processing

        #region Character recognition

        public string[] findText()
        {
            string fontFile = directory + fontName + mlpFileExtension;
            HTuple ocrHandle;
            if (image != null)
            {
                textModel.CreateTextModelReader("auto", fontFile);
                //ocrMlp.ReadOcrClassMlp(fontFile);
                HOperatorSet.ReadOcrClassMlp(fontFile, out ocrHandle);
                string Expression = @"([A-Z]{3}[0-9]{5}.?[A-Z][0-9]{4}[A-Z][0-9]{4})";

                HTextResult textresu = textModel.FindText(image);

               // HObject chars = textresu.GetTextObject("all_lines");
                HTuple resultValue = textresu.GetTextResult("num_lines");
                string[]  textFound = new string[resultValue];

                for (int i = 0; i < resultValue; i++)
                {
                    HTuple clas, confidence, word, score;
                    HTuple resultName = new HTuple("line",i);
                    HObject chars = textresu.GetTextObject(resultName);
                    HOperatorSet.DoOcrWordMlp(chars, image, ocrHandle, Expression, 3, 5,out clas, out confidence, out word, out score);
                   // ocrMlp.DoOcrWordMlp((HRegion)chars, image, Expression, 3, 5, out confidence, out word, out score);
                    textFound[i] = word;
                }
                return textFound;
            }
            return null;
        }

        #endregion // image processing




    }
}
