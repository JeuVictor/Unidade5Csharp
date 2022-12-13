using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoChatoCarro
{
    internal class Config
    {
        public int Questao;
        public bool Parar = false;
        public int id;
        public void Mensagem()
        {
            Console.WriteLine("Questão 1: Faça um programa em C# que leia uma quantidade indefinida de objetos Carro, composto pelos atributos, marca, valor, cor, modelo e ano, e:\r\n- Ordene os carros pelo de maior valor;\r\n- Imprima na tela todos os carros ordenados do maior valor para o de menor valor;\r\nQuestão 2: Baseado no programa anterior (Questão 1) Crie uma interface para Cadastrar,\r\nExcluir e Listar os carros.\r\n- Cadastre um carro.\r\n- Exclua um carro.\r\n- Liste todos os carros do menor valor para o maior valor.\r\nQuestão 3: Escreva um programa em C# que deverá ter as seguintes opções:\r\n- Carregar Vetor.\r\n- Listar Vetor.\r\n- Exibir apenas os números pares do vetor.\r\n- Exibir apenas os números ímpares do vetor.\r\n- Exibir a quantidade de números pares existentes nas posições ímpares do vetor.\r\n- Exibir a quantidade de números ímpares existentes nas posições pares do vetor.\r\n- Sair\r\nObservação: Deverá ser implementado um método para realizar cada uma das opções acima.\r\n");
            Console.WriteLine("");
            Console.WriteLine("Escolha a questão: ");
            Console.WriteLine("");
        }
    }
}
