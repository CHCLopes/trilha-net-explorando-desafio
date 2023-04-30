using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Saudacao
    {
        public void boasVindas1()
        {
            Console.WriteLine("\nBem Vindo aos meus exercícios de C# no Bootcamp Microsoft Dynamics 365 da DIO. Me chamo Carlos, e sou um desenvolvedor em eterna aprendizagem.");
        }
        public void sobreProjetoHotel()
        {
            Console.WriteLine($"\n    Fui contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel.\n    A solicitação pedia para representar o hóspede, a suíte, e a reserva. A reserva fará um relacionamento entre\nhóspede e suíte, calculando o investimento necessário e quando consultada, precisará trazer a quantidade de hóspedes\ne o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.\n");            
        }
        public void saudacaoHotelAloha()
        {
            Console.WriteLine("\nBem Vindo ao Hotel Aloha. Aonde seus melhores sonhos se materializam.");
        }
        
    }
}