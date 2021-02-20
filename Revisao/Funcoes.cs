using System;

namespace Revisao{
    class Funcoes{
        Aluno[] alunos = new Aluno[5];
        int indiceAluno = 0;

        public void adicionarAluno()
        {
            Aluno aluno = new Aluno();
            
            Console.WriteLine("Informe o nome: ");            
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe a nota: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else{
                throw new ArgumentException("Valor da nota de ser decimal");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;
        }

        public void listarAlunos()
        {
            if(indiceAluno == 0){
                throw new Exception("Nenhum aluno cadastrado");
            }

            for(int i=0; i<indiceAluno; i++)
            {
                Console.WriteLine($"Nome: {alunos[i].Nome}");
                Console.WriteLine($"Nota: {alunos[i].Nota}");
                Console.WriteLine();
            }

            aguardaVisualizacao();
        }
        
        public string MenuOpcoes()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }

        public void calcularMedia()
        {
            decimal resultado = 0;
            for(int i=0; i<indiceAluno; i++)
            {
                resultado += alunos[i].Nota;
            }

            resultado = resultado/indiceAluno;

            Console.WriteLine($"A turma com {indiceAluno} alunos teve media de: {resultado}");

            aguardaVisualizacao();
        }

        public void aguardaVisualizacao()
        {
            Console.WriteLine("Precione um botão para continuar");
            Console.ReadLine();
        }
    }
}