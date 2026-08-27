using ConsoleApp;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "João da Silva";
pessoa.DataNascimento = new DateTime(1990, 5, 15);
Curso curso = new Curso();
curso.NomeCurso = "ADS";
curso.Duracao = 3;

Console.WriteLine("O usuário {0} nasceu em {1} e sua matrícula é {2}. Ele faz o curso {3} com a duração de {4} anos.",
    pessoa.Nome,pessoa.DataNascimento,pessoa.gerarMatricula(), curso.NomeCurso, curso.Duracao);





