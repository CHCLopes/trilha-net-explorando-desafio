namespace DesafioProjetoHospedagem.Models
{
    public class MenuHotel
    {
        int escolha;
         public void menuHotel()
        {
            Saudacao saudacaoHotelAloha = new Saudacao();
            saudacaoHotelAloha.saudacaoHotelAloha();
            Console.WriteLine("\n Em que podemos ajudá-lo?\n\n    [1] Sou Cliente;\n    [2] Sou Colaborador;\n    [3] Sobre o Hotel;\n    [0] Sair. \n\n");
            
            escolha = Convert.ToInt32(Console.ReadLine());

            if(escolha == 0) 
            {
                Console.WriteLine("\nO Aloha Hotel agradece a sua visita. Seja sempre bem vindo. Volte sempre!");
            }
            else if(escolha == 1)
            {
                Usuario usuario = new Usuario();
                usuario.UsuarioCliente();
            }
            else if(escolha == 2)
            {
                Usuario colaborador = new Usuario();
                colaborador.UsuarioColaborador();
            }
            else if(escolha == 3)
            {
                Console.WriteLine("\nInfoHotel");
            }
        }
    }
}