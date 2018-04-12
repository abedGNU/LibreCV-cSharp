using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using HalconDotNet;

namespace CoreCV
{
    public static class Utilitiy
    {
        public static string logPath = @"Log\";
        public static string dataPath = @"dataRep\";

        public static void write_error(string classe, string metodo, Exception ex, DataType.eErrors type)
        {

                write_error(classe, metodo, ex.Message, type);
        }

        public static void write_error(string classe, string metodo, HOperatorException ex, DataType.eErrors type)
        {

            write_error(classe, metodo, ex.GetErrorCode()+" "+ex.Message, type);
        }

        public static void write_error(string classe, string metodo, string messaggio, DataType.eErrors type )
        {
            try
            {

                string msg = DateTime.Now.ToString() + " - " + classe + "." + metodo + ": " + messaggio;
                string typ = Enum.GetName(typeof(DataType.eErrors), type);

                        string nome_attuale = logPath + typ +"_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

                        if (File.Exists(nome_attuale) == false)
                        {
                            Stream stream = File.Create(nome_attuale);

                            stream.Close();
                        }

                        StreamWriter sw = new StreamWriter(nome_attuale, true);

                        sw.WriteLine(msg);

                        sw.Close();


            }
            catch (Exception ex)
            {
                ;
            }

        }
    }
}
