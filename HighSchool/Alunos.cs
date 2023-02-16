using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchool
{
    class Alunos
    {

        private string _nome;
        public int _c1, _c2, _c3, _c4, _c5, _c6, _c7, _c8;

        public override string ToString()
        {
            return _nome;
        }


        public double Media()
        {
            double resultado;
            return resultado = ((_c1 + _c2 + _c3 + _c4 + _c5 + _c6 + _c7 + _c8) / 8);
        }

          /*public Alunos(string Nota)
          {

          }*/
        public Alunos(string Nome, int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8)
        {
            this._nome = Nome;
            this._c1 = c1;
            this._c2 = c2;
            this._c3 = c3;
            this._c4 = c4;
            this._c5 = c5;
            this._c6 = c6;
            this._c7 = c7;
            this._c8 = c8;
        }
    }
}
