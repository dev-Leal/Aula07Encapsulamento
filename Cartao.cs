using System;

namespace Aula_07__Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        private string token = "a bia é linda e old que todos sabem ";

        protected string cvv { get; set; }

        public void AprovarCompra(){

         Console.WriteLine ("Sua compra foi aprovada!");

        }

        public bool ValidarToken (){

            if (token !=null)
            {
            return true;

            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }


    }
}