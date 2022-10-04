using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio_Fundamentos_NET_DIO.Models
{
    public class Estacionamento
    {      
        decimal precoPorHora;
        List<Carro> carro = new List<Carro>();

        public void AdicionarVeiculo(string placa, decimal precoInicial)
        {  
            string p1 = placa.Substring(0,3).ToUpper();   //separa a string desejada de 0 até o indice 3 pegando os valores antes do fim(0 1 e 2)
            string p2 = string.Format("{0,5}",placa.Substring(3)) ; //separa a string a partir do indice 3 inclusive e depois formata o restante em um espaço de 5 caracteres
            string plc = $"{p1}-{p2}"; //junta tudo em uma nova string permitindo um novo formato (XXX-xxxxx)

            //esta linha faz o mesmo procedimento das 3 linhas acima
            string plc1= placa.Insert(3,"-").ToUpper();

            carro.Add(new Carro(){Placa = plc1, PrecoInicial = precoInicial });
        }

       
        public void RemoverVeiculo(){

            if (carro.Count == 0)
            {
                Console.WriteLine("Não existem veículos cadastrados");
                Console.WriteLine("...VOltando ao Menu");
                return;
            }

            Console.WriteLine("SAÍDA DE VEÍCULOS");
            Console.Write("\nDigite a placa => : ");
            string? busca = Console.ReadLine();
            string plc = busca!.Insert(3,"-").ToUpper();

            //pesquisa o item pelo atributo Placa e descobre o indice
            int item = carro.FindIndex(0,i => i.Placa == plc);

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
                Console.WriteLine($"O Veículo de placa ''{plc}'' foi REMOVIDO.");
                Console.Write("Retornado ao MENU...\n");
                return;
               }
               else
               {
                Console.Clear();
                Console.WriteLine($"\nO Veículo da placa '{plc}' NÃO será removido.");
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
              ($" > PLACA => {carro.Placa} <==>  VALOR INICIAL => R$ {carro.PrecoInicial}"));
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