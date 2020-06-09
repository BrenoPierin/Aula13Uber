namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        private string carro;
        private string placa;

        public string aceitarPassageiro(string Nome){
            return "passageiro aceito";
        }

        public bool aceitarPagamento(string StatusCorrida){
            if(StatusCorrida == "finalizada"){
                return true;
            }
            return false;

        }
    }
}