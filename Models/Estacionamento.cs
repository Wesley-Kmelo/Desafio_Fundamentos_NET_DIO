using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Fundamentos_NET_DIO.Models
{
    public class Estacionamento
    {      
        decimal precoPorHora;
        List<Carro> carro = new List<Carro>();

        public void AdicionarVeiculo(string placa, decimal precoInicial)
        {            
            carro.Add(new Carro(){Placa = placa, PrecoInicial = precoInicial });
        }

       
        public void RemoverVeiculo(){

            Console.WriteLine("SAÍDA DE VEÍCULOS");
            Console.Write("\nDigite a placa => : ");
            string? busca = Console.ReadLine();

            //pesquisa o item pelo atributo Placa e descobre o indice
            int item = carro.FindIndex(0,i => i.Placa == busca);

            //indice de lista sempre começa em 0. Se não existir o indice , é pq a busca falhou.
            //Nesse caso, cai na condição else
            if (item >= 0)
            {
               decimal vlrTaxaInicial = carro[item].PrecoInicial;   
               Console.Write("\nQuantos minutos permaneceu no local=> : ");
               int minutos = Convert.ToInt32(Console.ReadLine()); 

               Console.Write("\nQual o valor do estacionamento por MINUTO => R$ ");
               precoPorHora = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\n MENSAGEM DO SISTEMA => ") ;
               Console.WriteLine(@$"O valor devido para o veículo de placa {carro[item].Placa}
                        é de R$ {vlrTaxaInicial+(precoPorHora * minutos)} ");
               Console.WriteLine("\nDeseja dar saída no veículo ?");
               Console.Write("Responda 'sim' ou 'não' => : ");

               if (Console.ReadLine() == "sim")
               {
                carro.RemoveAt(item); //remove pelo Indice atribuido acima 
                Console.Clear();
                Console.WriteLine($"O Veículo de placa ''{busca}'' foi REMOVIDO.");
                Console.Write("Retornado ao MENU...\n");
                return;
               }
               else
               {
                Console.Clear();
                Console.WriteLine("\nO Veículo NÃO será removido.");
                Console.WriteLine("\nPara remover Veículo, digite a opção 2 ");
                Console.WriteLine("Após os procedimentos responda 'sim'");
                return;
               }
            }
            else 
            {
            Console.WriteLine("\nA placa digitada não foi encontrada. ");
            Console.WriteLine($"Escolha a opção 3 e verifique se a placa '{busca}' existe.");
            return;
            }

        }

        public void ListarVeiculos(string usuario)
        {
            if (carro.Count >=1)
            {                
             Console.WriteLine("\n LISTA DE VEÍCULOS ESTACIONADOS\n");
             carro.ForEach(carro=>Console.WriteLine
              ($" > PLACA => {carro.Placa} VALOR INICIAL => R$ {carro.PrecoInicial}"));
            }
            else
            {
                Console.WriteLine("Não existem Veículos cadastrados !!!");
                Console.WriteLine($"{usuario} escolha a opção 1 ");                
            }
        }


        public class Carro 
        {
           // public Carro (){}
            public string? Placa {get; set;}
            public decimal PrecoInicial {get; set;}
        }
    }
}