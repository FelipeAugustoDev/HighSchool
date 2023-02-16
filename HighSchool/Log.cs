using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericTrue
{
    public class Log
    {
        const string info = "info";
        const string error = "error";
        const string warn = "warn";
        const string fatal = "fatal";
        string caminho;
        public Log()
        {
            caminho = "C:\\Users\\Felipe Augusto\\Pictures\\Logs\\";
            //string temp = Path.GetTempPath();
            //temp = temp.Replace("\\", "\\\\");
            caminho += "Log do dia " + DateTime.Today.ToString().Substring(0, 10).Replace("/", ".") + ".log";

        }

        public void logando(int tipo, string log)
        {
            string logando = "";
            switch (tipo)
            {
                case 0:
                    logando += Log.info + " " + log;
                    break;
                case 1:
                    logando += Log.error + " " + log;
                    break;
                case 2:
                    logando += Log.warn + " " + log;
                    break;
                case 3:
                    logando += Log.fatal + " " + log;
                    break;
            }
            salvarArquivo(logando);
        }



        public void salvarArquivo(string txt)
        {

            if (File.Exists(caminho))
            {
                StreamWriter salvarArquivo = new StreamWriter(caminho);
                string logAntigo = File.ReadAllText(caminho);   //ele está criando apenas 1 arquivo de log
                logAntigo += txt;
                salvarArquivo.WriteLine(logAntigo);
                salvarArquivo.Close();
            }
            else
            {
                StreamWriter salvarArquivo = new StreamWriter(caminho);
                salvarArquivo.WriteLine(IniciandoLog());
                salvarArquivo.Close();
            }
        }


        private string IniciandoLog()
        {
            return "Log Criado as " + DateTime.Now;
        }
    }
}
