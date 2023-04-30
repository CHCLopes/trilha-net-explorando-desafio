namespace DesafioProjetoHospedagem.Models
{
    public class Usuario
    {
        Pessoa usuario = new Pessoa();
        public void UsuarioCliente()
        {
            Console.WriteLine($"Por favor digite seu nome completo:"); 
            List<string> nomeUsuarioCliente   = Console.ReadLine().Split(" ",10).ToList();

            Pessoa usuario = new Pessoa();
            usuario.Nome = nomeUsuarioCliente[0];

            nomeUsuarioCliente.Remove(nomeUsuarioCliente[0]);

            string sobrenomeUsuarioCliente = string.Join(" ",nomeUsuarioCliente);
            usuario.Sobrenome = sobrenomeUsuarioCliente;

            Console.WriteLine($"\nBem vindo, Sr.(a) {usuario.Nome}");
        }
        public void UsuarioColaborador()
        {
            Console.WriteLine($"Por favor digite seu nome:"); 

            List<string> nomeUsuarioColaborador = Console.ReadLine().Split(" ",10).ToList();
            usuario.Nome = nomeUsuarioColaborador[0];       

            AcessoColaborador(); 
        }
        
        public void AcessoColaborador()
        {   
            int matriculaColaborador = 123456, senhaColaborador = 123456, escolha;

            Console.WriteLine($"Por favor digite sua matrícula '123456':"); 
            int matriculaUsuario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Por favor digite sua senha '123456':"); 
            int senhaUsuario = Convert.ToInt32(Console.ReadLine());

                if(matriculaUsuario != matriculaColaborador || senhaUsuario != senhaColaborador)
                {
                    Console.WriteLine("Usuário e/ou Senha Inválidos. Deseja tentar novamente?\n\n    [1] SIM;\n    [2] NÃO/SAIR;");
                    escolha = Convert.ToInt32(Console.ReadLine());

                    if(escolha == 0) 
                    {
                        Console.WriteLine("\nO Aloha Hotel agradece a sua visita. Seja sempre bem vindo. Volte sempre!");
                    }
                    else if(escolha == 1)
                    {
                        AcessoColaborador();
                    }
                    else
                    {
                        Console.WriteLine($"\nBem vindo, Sr.(a) {usuario.Nome}");                      
                    }                    
                }
                else
                {
                    Console.WriteLine($"\nBem vindo, Sr.(a) {usuario.Nome}");
                }
        }      
    }
}
