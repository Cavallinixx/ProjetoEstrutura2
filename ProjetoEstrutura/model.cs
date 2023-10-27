using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {
        public double[] notas;//Declaração de um vetor
        public int[] vetor;
        public int[] num;
        public int[] numMaior;
        public double[] notas20;
        public int i;
        private double[] numDouble;
        public double[] pares;
        public double[] pares15;
        private double soma;
        public int j;


        public Model()
        {
            notas = new double[10];
            notas20 = new double[20];
            vetor = new int[5];//Instanciar = Existir 
            num = new int[10];

            numDouble = new double[20];
            numMaior = new int[25];
            pares = new double[10];
            pares15 = new double[15];
            i = 0;
            j = 0;
            ConsultarSoma = 0;
            


        }//fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { this.soma = value; }
        }//fim do get set

        //Exercicio teste - Guardar 10 notas de 10 alunos diferentes
        public double MediaNotas()
        {
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }//fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//fim do for
            return ConsultarSoma / i;
        }//fim método

        //Exercicio 1 Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for (i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo o vetor
            }//fim do for
        }//fim do método

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + vetor[i]);
            }//fim do for
        }//fim do mostrar

        // Exercicio 3 - Ler e mostrar somente os números pares
        public void PreencherVetor10Posicoes()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "° Número: ");
                pares[i] = Convert.ToInt32((Console.ReadLine()));
            }//fim for
        }
        public void NumPar()
        {
            for (i = 0; i < 10; i++)
            {
                if (pares[i] % 2 == 0)
                {
                    Console.WriteLine(pares[i]);
                }//fim  do if
         
            }//fim for 
        }//fim metodo
        
        //Exercicio 04
        public double PreencherVetor20Posicoes()
        {
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + " ª nota : ");
                notas20[i] = Convert.ToDouble((Console.ReadLine()));
                do
                {
                    if (notas20[i] < 0)
                    {
                        Console.WriteLine("Digite um valor positivo!! ");
                    }//fim da validação
                } while (notas20[i] < 0);

                 ConsultarSoma += notas20[i];
            }
            return ConsultarSoma / i;
        }// fim do método 

        //exercicio 5 - Contar quantos números são pares
       
        public double ContarNumerosPares()
        {

            for (i = 0; i < 15; i++)
            {
                Console.WriteLine((i + 1) + " º Número : ");
                pares15[i] = Convert.ToDouble((Console.ReadLine()));
                if (pares15[i] % 2 == 0)
                {
                 
                    j = j + 1;
                }//fim  do if

               
            }//fim for 
            return j;
        }//Fim método

            //Exercicio 06 - Ler os números e mostrar o Maior  

            public double MostrarPosicao()
            {
                for (i = 0; i < 25; i++)
                {
                    Console.WriteLine((i + 1) + " º número: ");
                    numMaior[i] = Convert.ToInt32((Console.ReadLine()));

                    do
                    {
                        if (numMaior[i] < 0)
                        {
                            Console.WriteLine("Informe um número positivo!!");
                        }// Fim validação
                    } while (numMaior[i]< 0);

                 
                }// fim for
                return MostrarPosicao();
            }// fim metodo 

    }//fim da classe
}//fim do projeto