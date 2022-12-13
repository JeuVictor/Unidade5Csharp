using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoChatoCarro
{
    internal class Ativ3
    {
        public int[] Vetor = new int[10];
        public int opc;
        public bool Sair = false;
        public int qtd;
        public void mensagem()
        {
            Console.WriteLine("1- Carregar Vetor.\r\n2- Listar Vetor.\r\n3- Exibir apenas os números pares do vetor.\r\n4- Exibir apenas os números ímpares do vetor.\r\n5- Exibir a quantidade de números pares existentes nas posições ímpares do vetor.\r\n6- Exibir a quantidade de números ímpares existentes nas posições pares do vetor.\r\n7- Sair\r\n");
            Console.WriteLine(""); 
            Console.WriteLine("Digite a opção desejada: ");

        }
        public void Carregar()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o numero " + (i + 1) + "° do Vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Listar()
        {
            Console.WriteLine("_________________");
            for (int i = 0; i < Vetor.Length; i++)
            {
                Console.WriteLine(Vetor[i]);
            }
            Console.WriteLine("_________________");
        }
        public void Pares()
        {
            Console.WriteLine("_________________");
            for (int i = 0; i < Vetor.Length; i++)
            {
                if (Vetor[i] % 2 == 0)
                { Console.WriteLine(Vetor[i]); }
                
            }
            Console.WriteLine("_________________");
        }
        public void Impares()
        {
            Console.WriteLine("_________________");
            for (int i = 0; i < Vetor.Length; i++)
                if (Vetor[i] % 2 == 0)
                    { }
            else
                {
                    Console.WriteLine(Vetor[i]);
                }
            Console.WriteLine("_________________");
        }
        public void QtdPares()
        {
            Console.WriteLine("_________________");
            qtd = 0;
            for (int i = 0; i < 10; i+=2)
            {
                if (Vetor[i] % 2 == 0)
                {  qtd++; Console.WriteLine(i);    }
            }
            Console.WriteLine(qtd);
            Console.WriteLine("_________________");

        }
        public void QtdImpares()
        {
            Console.WriteLine("_________________");
            qtd = 0;
            for (int i = 0; i < 10; i++)
                if (Vetor[i] % 2 == 0)
                { }
                else
                {
                    qtd++;
                }
            Console.WriteLine(qtd);
            Console.WriteLine("_________________");
        }
    }
}
