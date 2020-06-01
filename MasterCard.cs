using System;

namespace Aula_07__Encapsulamento {
    
    public class MasterCard : Cartao {

       
        public int parcelas { get; set; }

        //Utilizando o encapsulamento com assinatura "protected"

        public void ComprarComDescontoMasterCard (float desconto) {
            cvv = "222";
            Console.WriteLine ($"Sua compra foi realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }
    }
}