namespace Aula13Uber
{
    public class Cartao : Passageiro
    {
        private string numero;
        private string  titular;
        private string bandeira;
        private string cvv;

        public string cadastrar(){
            if(numero != ""){
                return "cadastrado com sucesso!";
            }
            return "cadastro não efetuado com sucesso";
        }

        public string excluir(){
            return "cartão excluido com sucesso";
        }

    }
}