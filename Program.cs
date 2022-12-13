using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoChatoCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config();
            config.Mensagem();
            config.Questao = int.Parse(Console.ReadLine());
            Console.Clear();
            if (config.Questao == 1)
            {
                List<Carros> carr = new List<Carros>();

                string sair;
                do
                {

                    Carros carros = new Carros();
                    Console.WriteLine("Digite Marca do Carro");
                    carros.MarcaCarro = Console.ReadLine();
                    Console.WriteLine("Digite o Valor do Carro");
                    carros.Valores = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a Cor do Carro");
                    carros.CorCarro = Console.ReadLine();
                    Console.WriteLine("Digite o Modelo do Carro");
                    carros.ModeloCarro = Console.ReadLine();
                    Console.WriteLine("Digite o Ano do Carro");
                    carros.AnoCarro = Convert.ToInt32(Console.ReadLine());
                    carr.Add(carros);
                    Console.WriteLine("Deseja encerrar? S/N");
                    sair = Console.ReadLine();



                } while (sair.Equals("n"));
                Console.Clear();

                foreach (var item in carr.OrderByDescending(s => s.Valores).ToList())
                {
                    Console.WriteLine(String.Format("\nMarca do Carro: {0}", item.MarcaCarro));
                    Console.WriteLine($"\nMarca do Carro: {item.Valores}");
                }


            }
            if (config.Questao == 2)
            {
                int Ids;

                List<Carros> carros2 = new List<Carros>();
                do
                {
                    Carros ativ2 = new Carros();
                    ativ2.Mensagem();
                    ativ2.Acao = int.Parse(Console.ReadLine());
                        List<Carros> carros1 = new List<Carros>();
                    if (ativ2.Acao == 1)
                    {

                        string sair;
                        do
                        {

                            Carros carros = new Carros();
                            Console.WriteLine("Digite Marca do Carro");
                            carros.MarcaCarro = Console.ReadLine();
                            Console.WriteLine("Digite o Valor do Carro");
                            carros.Valores = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite a Cor do Carro");
                            carros.CorCarro = Console.ReadLine();
                            Console.WriteLine("Digite o Modelo do Carro");
                            carros.ModeloCarro = Console.ReadLine();
                            Console.WriteLine("Digite o Ano do Carro");
                            carros.AnoCarro = Convert.ToInt32(Console.ReadLine());
                            config.id++;
                            carros.id= config.id;
                            carros2.Add(carros);
                            
                            Console.WriteLine("Deseja encerrar? S/N");
                            sair = Console.ReadLine();
                           


                        } while (sair.Equals("n"));
                        Console.Clear();
                    }
                    else if (ativ2.Acao == 2)
                    {
                        foreach (var item in carros2.ToList())
                        {
                            Console.WriteLine(String.Format("\nMarca do Carro: {0}", item.MarcaCarro));
                            Console.WriteLine($"\nValor do Carro: {item.Valores}");
                            Console.WriteLine($"\nID do Carro: {item.id}");
                            Console.WriteLine("________________________________________________________");
                        }
                        Console.WriteLine("Digite o id que deseja excluir:");
                        Ids=int.Parse(Console.ReadLine());
                        if (Ids>0)
                            {
                            var itemToRemove = carros2.Single(r => r.id == Ids);
                            carros2.Remove(itemToRemove);
                        }
                    }
                    else { config.Parar = true; }
                        
                } while (config.Parar == false);
              
            }
            if (config.Questao == 3)
            {
                Ativ3 atv3 = new Ativ3();
                do
                {
                    atv3.mensagem();
                    atv3.opc = int.Parse(Console.ReadLine());
                    if (atv3.opc==1)
                    { atv3.Carregar(); atv3.opc = 0; }
                    else if (atv3.opc == 2)
                    { atv3.Listar(); }
                    else if (atv3.opc == 3)
                    { atv3.Pares(); }
                    else if (atv3.opc == 4)
                    { atv3.Impares(); }
                    else if(atv3.opc == 5)
                    { atv3.QtdPares(); }
                    else if (atv3.opc == 6)
                    { atv3.QtdImpares(); }
                    else if (atv3.opc ==7)
                    { atv3.Sair = true; }
                } while (atv3.Sair == false);
                    
            }
            Console.ReadKey();
        }
    }
}