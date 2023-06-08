class Exercicio4
{
    public static void main(){

        Console.WriteLine("[---------------------------------------------------]");
        Console.WriteLine("[   Vamos calcular quantos dias você tem de vida?   ]");
        Console.WriteLine("[---------------------------------------------------]");

        Console.WriteLine("Insira quantos kilos você pescou hoje: ");
        int anos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira quantos kilos você pescou hoje: ");
        int meses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira quantos kilos você pescou hoje: ");
        int dias = Convert.ToInt32(Console.ReadLine());

       
        int idadeTotal = 2023 - anos - 1;
        int totalDias = (idadeTotal * 365) + (meses * 30) + dias;

        Console.WriteLine("[-----------------------------------------------------------------------------------------------]");
        Console.WriteLine("[ Você tem atualmente: " + idadeTotal + " anos," + " que da no total de " + totalDias + " dias. ]");
        Console.WriteLine("[-----------------------------------------------------------------------------------------------]");
    }
}