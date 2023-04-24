using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Menu
    {
         public void menuInicio ()
        {   
            Console.WriteLine("\nDigite a opção desejada: \n\n    [1] Projeto Hotel; \n    [0] Sair. \n");

            int escolha = Convert.ToInt32(Console.ReadLine());
            do{
                if(escolha == 0) 
                {
                    Console.WriteLine("\nObrigado por me visitar. Seja sempre bem vindo. Volte sempre!\n");
                    break;
                } 
                else if(escolha == 1)
                {
                    Saudacao saudacao1 = new Saudacao();
                    saudacao1.sobreProjetoHotel();

                    Console.WriteLine("O que deseja fazer? \n\n    [1] Ir para o Projeto Hotel;\n    [2] Voltar ao Menu Anterior;\n    [0] Sair. \n\n");

                    escolha = Convert.ToInt32(Console.ReadLine());

                    if(escolha == 0) 
                    {
                    Console.WriteLine("\nObrigado por me visitar. Seja sempre bem vindo. Volte sempre!\n");
                    break;
                    }
                    else if(escolha == 2)
                    {
                    Menu menuHotel1 = new Menu();
                    menuHotel1.menuInicio();
                    }
                    else if(escolha == 2)
                    {
                    Menu menuInicio = new Menu();
                    menuInicio.menuInicio();
                    }
                }
            } 
            while (escolha != 0 && escolha <= 1);
        }

        public void menuHotel1()
        {
        
        }
    }
}