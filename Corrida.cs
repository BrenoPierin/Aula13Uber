namespace Aula13Uber
{
    public class Corrida
    {
        private string localInicio;
        private string destino;
        private string statusCorrida ;
        private string passageiro;
        private string motorista;

        public string cancelar(){
            if(statusCorrida != "finalizado"){
                return "corrida cancelada";
            }
            return "não é possivel cancelar a corrida agora!";
        }
        
    }
}