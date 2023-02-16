using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GenericTrue;

namespace HighSchool
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        OpenFileDialog lerArquivo = new OpenFileDialog();
        Log log = new Log();

        /// <summary>
        /// Pegar o arquivo de extensao .csv
        /// </summary>
        /// <returns></returns>
        public string metodoPegarArquivo()
        {
            lerArquivo.Filter = "Arquivo CSV (*.csv)|*.csv";
            string caminho = lerArquivo.FileName;
            string Texto;


            if (lerArquivo.ShowDialog() != DialogResult.OK) return null;

            try { Texto = File.ReadAllText(caminho); return Texto; }
            catch (Exception) { return null; }


        }
        /// <summary>
        /// Método de quebra de linhas e adicionar os itens diretamente no ListBox
        /// </summary>
        public void quebraLinha()
        {
            string caminho = lerArquivo.FileName;
            string Texto = File.ReadAllText(caminho);
            int i = 0;
            foreach (var linha in Texto.Split('\n'))
            {
                if (linha == "" || linha == "\r") break;
                if (i != 0)
                {
                    //Tratando dos dados
                    string[] posicao = linha.Split(';');
                    string[] notas = linha.Split(';');
                    //crianddo o obj
                    Alunos aluno = new Alunos(posicao[0], int.Parse(posicao[1]), int.Parse(posicao[2]), int.Parse(posicao[3]), int.Parse(posicao[4]), int.Parse(posicao[5]), int.Parse(posicao[6]), int.Parse(posicao[7]), int.Parse(posicao[8]));
                    //Adicionando em pessoas as informações do arquivo
                    lboAlunos.Items.Add(aluno);
                    if (aluno.Media() > 50) { lboMedias.Items.Add(aluno.Media().ToString() + " - " + "Passou"); }
                    else
                    {
                        lboMedias.Items.Add(aluno.Media().ToString() + " - " + "Nao passou");
                    }
                }
                i++;
            }
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            
            metodoPegarArquivo();
            quebraLinha();
            log.logando(0, "Dados Inseridos e média calculada");
        }
    }
}
