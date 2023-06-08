class Exercicio1
{
    public static void main(){

        Console.WriteLine("Insira quantos kilos você pescou hoje: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        double multa = 4.00;

        Console.WriteLine("O Peixe dele pesa: " + peso + " kilos");
    
        if(peso > 50){
            double exedente = peso - 50;
            double precoMulta = exedente * multa;
            Console.WriteLine("Ele precisa pagar: R$ " + precoMulta + ",00 de multa!");
        } 

        if(peso <= 50) {
            Console.WriteLine("Ele está dentro do peso permitido");
        }
    }
}