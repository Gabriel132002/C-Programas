using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    class Disciplina
    {
        private string disciplina;

        public Disciplina(string disciplina)
        {
            this.disciplina = disciplina;
        }
        public string getDisciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
    }
}
