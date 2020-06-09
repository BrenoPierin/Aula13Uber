using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
             Usuario user = new Usuario();

            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            user.Login(login, senha);

            if(user.tokenLogin != "" && user.tokenLogin != null){

                Console.WriteLine("Acesso liberado! Usuário logado");
                System.Console.WriteLine(user.tokenLogin);

            }else{
                Console.WriteLine("Usuario deslogado");
            }

            Passageiro pas = new Passageiro();
            System.Console.WriteLine(pas.solicitarMotorista()); 
            System.Console.WriteLine(pas.Pagamento("finalizado")); 


            Pagamento pagamento = new Pagamento();
            System.Console.WriteLine(pagamento.pagamento()); 
            


        }
    }
}
