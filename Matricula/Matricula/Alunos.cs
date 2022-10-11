using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    class Alunos
    {
        private int nummatricula;
        private int telefone;
        private string nome;

        public Alunos(int nummatricula, int telefone, string nome)
        {
            this.nummatricula = nummatricula;
            this.telefone = telefone;
            this.nome = nome;
        }

        public int getMatricula
        {
            get { return nummatricula; }
            set { nummatricula = value; }
        }
        public int getTelefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string getNome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
