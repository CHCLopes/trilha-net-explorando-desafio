namespace DesafioProjetoHospedagem.Models;

public class MenuInicio
{            
    public void menuInicio()
    {
        int escolha;

        Console.WriteLine("\nDigite a opção desejada: \n\n    [1] Projeto Hotel; \n    [0] Sair. \n");        
        escolha = Convert.ToInt32(Console.ReadLine());

        if(escolha == 0) 
        {
            Console.WriteLine("\nObrigado por me visitar. Seja sempre bem vindo. Volte sempre!\n");
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
            }
            else if(escolha == 1)
            {
                MenuHotel menuHotel = new MenuHotel();
                menuHotel.menuHotel();
            }
            else if(escolha == 2)
            {
                MenuInicio menuInicio = new MenuInicio();
                menuInicio.menuInicio();
            }
        } 
    }
}