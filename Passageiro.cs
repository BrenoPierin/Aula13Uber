namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string procurandoMotorista(){
            return "Procurando motoristas disponiveis...";

        }

        public string Pagamento(string StatusCorrida){
            if(StatusCorrida == "Finalizada"){
                return "pagamento efetuado";
            }
            return "Pagamento pendente pois a corrida não foi finalizada!";
        }
    }
}