using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Control
    {
        Model modelo;
        private int opcao;
        public Control()
        {
            this.modelo = new Model();//Criando uma chave
            ConsultarOpcao = -1;
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do método

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair\n" +
                              "1. Média de notas 10 alunos\n" +
                              "2. Vetor Inverso\n" +
                              "3. Número Par \n" +
                              "4. Média de notas 20 alunos\n" +
                              "5. Quantidade de números pares\n" +
                              "6.Mostrar o maior valor\n" +
                              "7. \n" +
                              "8.  \n" +
                              "9. \n" +
                              "10. \n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            do
            {
                Menu();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                        break;
                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        this.modelo.PreencherVetor10Posicoes();
                        this.modelo.NumPar();
                        break;
                    case 4:
                        Console.WriteLine(("A média dos valores digitados é : ") + modelo.PreencherVetor20Posicoes());

                        break;
                    case 5:
                       Console.WriteLine(("Há: ") + modelo.ContarNumerosPares() + " números pares"); 
                        break;
                    case 6:
                        Console.WriteLine(modelo.MostrarPosicao() + (modelo.j));
                        break;
                    default:
                        Console.WriteLine("Erro, escolha uma opção valida!");
                        break;
                }//fim do switch
            } while (ConsultarOpcao != 0);
        }//fim do método operacao




    }//fim da classe
}//fim do projeto