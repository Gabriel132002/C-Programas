using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    public class Alunos
    {
        private int telefone;
        private string nome;
        private string disciplina;
        private string curso;
        private string email;

        public Alunos(int telefone, string nome, string disciplina, string curso, string email)
        {
            this.telefone = telefone;
            this.nome = nome;
            this.disciplina = disciplina;
            this.curso = curso;
            this.email = email;
        }
        public string getCurso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string getEmail
        {
            get { return email; }
            set { email = value; }
        }
        public string getDisciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
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
