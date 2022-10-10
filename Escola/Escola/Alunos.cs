using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
     class Alunos
     {
        private int Matricula;
        private string Nome;
        private double N1;
        private double N2;
        private double Media;
        private string Status;

        public Alunos(int Matricula, string Nome, double N1, double N2, double Media, string Status)
        {
            this.Matricula = Matricula;
            this.Nome = Nome;
            this.N1 = N1;
            this.N2 = N2;
            this.Media = Media;
            this.Status = Status;
        }

        public int getMatricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string getNome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public double getN1
        {
            get { return N1; }
            set { N1 = value; }
        }
        public double getN2
        {
            get { return N2; }
            set { N2 = value; }
        }
        public double getMedia
        {
            get { return Media; }
            set { Media = value; }
        }
        public string getStatus
        {
            get { return Status; }
            set { Status = value; }
        }


       
     }
}
