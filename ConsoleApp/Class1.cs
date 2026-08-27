using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ConsoleApp;

namespace ConsoleApp
{
    public class Pessoa
    {
        string nome;
        private string matricula;
        private DateTime dataNascimento;

        public string Nome 
        { 
            get => nome; 
            set => nome = value;
        }
        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }
        
        public DateTime DataNascimento 
        { 
            get => dataNascimento; 
            set => dataNascimento = value; 
        }

        public string gerarMatricula()
        {
            var gerador = Convert.ToInt64(Convert.ToString(DateTime.Now.Ticks))*100;
            return gerador.ToString();
        }
    }
}
