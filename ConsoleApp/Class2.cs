using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ConsoleApp;

namespace ConsoleApp
{
    public class Curso
    {
        int codCurso; 
        string nomeCurso;
        int duracao;

        public int CodCurso
        {
            get => codCurso;
            set => codCurso = value;
        }
        public string NomeCurso
        {
            get => nomeCurso;
            set => nomeCurso = value;
        }

        public int Duracao
        {
            get => duracao;
            set => duracao = value;
        }

    }
}