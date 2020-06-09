namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "breno.pierin@gmail.com";
        private string senha  = "123456789";
        public string foto { get; set; }
        public string localizacaoAtual { get; set; }
        public string tokenLogin { get; set; }


        public bool Login(string login, string senha){

            if(this.login == login && this.senha == senha){
                tokenLogin = "ofjsjhoidsOEU78TF8CEIFBPUDCH87E";
                return true;
            }

                return false;
        }

        public void Logout(){
            tokenLogin = "";
        }
    }
}