using System;
using HalconDotNet;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace MatchingModule
{
    /// <summary>
    /// This class optimizes the performance of a defined shape-based model
    /// for a given set of test images.
    /// To perform an optimization of the detection parameters, the instance
    /// has to know the used set of matching parameters and the calling 
    /// MatchingAssistant, to retrieve the set of test images and to call 
    /// the methods for finding the model. 
    /// The optimization is performed in the sense that the two detection 
    /// parameters ScoreMin and Greediness are iteratively increased and
    /// decreased, respectively, and every new parameter combination is used
    /// to detect the model in the set of test images. Each performance is
    /// then measured and compared with the best performance so far.
    /// The single execution steps are triggered by a timer from the
    /// class MatchingAssistant, so that you can stop the optimization anytime
    /// during the run.
    /// </summary>
   	public class MatchingOptSpeed: MatchingOpt
	{
		// private class members 
		private int		mCurrScoreMin;
		private int		mCurrGreediness;
		private double	mCurrMeanTime;
		private int		mScoreMinStep;
		private int		mGreedinessStep;
		
		private int		mOptScoreMin;
		private int		mOptGreediness;
		private double  mOptMeanTime;

		private int		mMatchesNum;
		private int		mExpMatchesNum;
		

		/// <summary>Constructor</summary>
		/// <param name="mAss">MatchingAssistant that created this instance</param>
		/// <param name="mPars">Current set of matching parameters</param>
		public MatchingOptSpeed(MatchingAssistant mAss, MatchingParam mPars)
		{
			mAssistant	= mAss;
			mParams		= mPars;
			NotifyStatisticsObserver = new StatisticsDelegate(dummy);
			
			mScoreMinStep	= -10;
			mGreedinessStep	= 10;
			reset();
			
			tImageCount		= mAssistant.TestImages.Count;
		}

		
        /// <summary>
        /// In each execution step a certain parameter set is applied 
        /// to the whole set of test images and the performance is then
        /// evaluated.
        /// </summary>
        public override bool ExecuteStep()
		{	
			double cScoreMin, cGreed, recogRate;
			string fileName;
			int actualMatches, expectedMatches;
			bool success;
			
			if(!iterator.MoveNext())
				return false;
			
			
			cScoreMin = mCurrScoreMin / 100.0;
			cGreed	  = mCurrGreediness / 100.0;

			statusString =	"Testing Image  " + (mCurrentIndex + 1) + 
							"  - Minimum Score:  " + cScoreMin +
							"  - Greediness:  "    + cGreed;
			
			NotifyStatisticsObserver(MatchingOpt.UPDATE_RECOG_STATISTICS_STATUS);

			fileName = (string)iterator.Current;
			
			mAssistant.setTestImage(fileName);
			
			mAssistant.setMinScore(cScoreMin);
			mAssistant.setGreediness(cGreed);

			if(!mAssistant.applyFindModel())
				return false;
			
			
			mResults	    = mAssistant.getMatchingResults();
			actualMatches   = mResults.count;

			expectedMatches = 0;

			switch(mParams.mRecogSpeedMode)
			{
				case MatchingParam.RECOGM_MANUALSELECT:
					expectedMatches = mParams.mRecogManualSel;
					break;
				case MatchingParam.RECOGM_ATLEASTONE:
					expectedMatches = 1;
					if(actualMatches > 1)
						actualMatches = 1;
					break;
				case MatchingParam.RECOGM_MAXNUMBER:
					expectedMatches = mParams.mNumMatches;
					break;
				default:
					break;
			}
			
			mMatchesNum		+= actualMatches;
			mExpMatchesNum	+= expectedMatches;
			
			
			recogRate = (mExpMatchesNum > 0) ? 
						(100.0 * mMatchesNum / mExpMatchesNum) : 0.0;

			mCurrMeanTime  = mCurrMeanTime * mCurrentIndex + mResults.mTime;
			mCurrMeanTime /= ++mCurrentIndex;
						
			//write data into strings and call for update
			recogTabOptimizationData [0] = "" + Math.Round(cScoreMin, 2); 
			recogTabOptimizationData [1] = "" + Math.Round(cGreed, 2); 
			recogTabOptimizationData [2] = "" + Math.Round(recogRate, 2) + " %"; 
			
			if( mCurrMeanTime < 1000.0 ) 
				recogTabOptimizationData [3] = Math.Round(mCurrMeanTime, 2) + "  ms"; 
			else
				recogTabOptimizationData [3] = Math.Round(mCurrMeanTime/1000.0, 2)+ "  s"; 

			NotifyStatisticsObserver(MatchingOpt.UPDATE_RECOG_UPDATE_VALS);

			if(mCurrentIndex < tImageCount)
				return true;

			iterator.Reset();
			mCurrentIndex	= 0;
			mMatchesNum		= 0;
			mExpMatchesNum	= 0;

			success = (mParams.mRecogRateOpt == 0) ?	
						  (Math.Abs((double)recogRate - mParams.mRecogRate) < 0.001) 
						: (recogRate >= (mParams.mRecogRate - 0.000001));


			if(success)
			{
				mOptSuccess = true;
				if(mCurrMeanTime < mOptMeanTime)
				{
					mOptScoreMin	= mCurrScoreMin;
					mOptGreediness	= mCurrGreediness;

					this.recogTabOptimizationData[4] = "" + Math.Round(mOptScoreMin/100.0, 2);   
					this.recogTabOptimizationData[5] = "" + Math.Round(mOptGreediness/100.0, 2); 
					this.recogTabOptimizationData[6] = Math.Round(recogRate, 2) + " %";		  

					mOptMeanTime	= mCurrMeanTime;
					recogTabOptimizationData[7] = recogTabOptimizationData[3];	  
					NotifyStatisticsObserver(MatchingOpt.UPDATE_RECOG_OPTIMUM_VALS);
				}
				mCurrGreediness += mGreedinessStep;
				return (mCurrGreediness <= 100);
			}
			
			mCurrScoreMin += mScoreMinStep;

			if(mOptSuccess)
				return (mCurrScoreMin >= 10);
			
			return (mCurrScoreMin > 0); 
		}


        /// <summary>
        /// Resets all parameters for evaluating the performance to their initial values.
        /// </summary>
        public override void reset()
		{
			mOptSuccess		= false;

			for(int i=0; i<8; i++)
				this.recogTabOptimizationData[i]="-";
			
			statusString = "Optimization Status:";

			mCurrScoreMin	= 100;
			mCurrGreediness = 0;
			mCurrMeanTime	= 0.0;
			
			mOptScoreMin	= 100;
			mOptGreediness	= 0;
			mOptMeanTime	= Double.MaxValue;
			
			mMatchesNum		= 0;
			mExpMatchesNum	= 0;

			tImageCount		= mAssistant.TestImages.Count;
			iterator		= mAssistant.TestImages.Keys.GetEnumerator();
			mCurrentIndex	= 0;
		}


        /// <summary>
        /// If the optimization has stopped, then check whether it was
        /// completed successfully or whether it was aborted due to errors or
        /// to user interaction.
        /// Depending on the failure or success of the run, the GUI is notified
        /// for visual update of the results and obtained statistics.
        /// </summary>
		public override void stop()
		{
			if(tImageCount==0)
			{
				NotifyStatisticsObserver(MatchingAssistant.ERR_NO_TESTIMAGE);
				NotifyStatisticsObserver(MatchingOpt.RUN_FAILED);
			}
			else if(!mOptSuccess && (mCurrScoreMin==0.0))
			{
				NotifyStatisticsObserver(MatchingOpt.UPDATE_RECOG_ERR);
				NotifyStatisticsObserver(MatchingOpt.RUN_FAILED);
			}
			else if(!mOptSuccess)
			{
				NotifyStatisticsObserver(MatchingOpt.UPDATE_TEST_ERR);
				NotifyStatisticsObserver(MatchingOpt.RUN_FAILED);
			}
			else
			{
				statusString = "Optimization finished successfully";
				NotifyStatisticsObserver(MatchingOpt.UPDATE_RECOG_STATISTICS_STATUS);
				mAssistant.setMinScore(mOptScoreMin/100.0);
				mAssistant.setGreediness(mOptGreediness/100.0);
				NotifyStatisticsObserver(MatchingOpt.RUN_SUCCESSFUL);
			}
		}
	}//end of class
}//end of namespace
