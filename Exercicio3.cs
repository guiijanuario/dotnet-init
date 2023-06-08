class Exercicio3
{
    public static void main(){

        Console.WriteLine("[-----------------------------------------------]");
        Console.WriteLine("[   Veja quantos salários minimos você ganha!   ]");
        Console.WriteLine("[-----------------------------------------------]");

        Console.WriteLine("Insira o seu salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double salarioMinimo = 1212.00;

        double quantidadeSalarios = salario / salarioMinimo;

        Console.WriteLine("Você recebe: " + quantidadeSalarios.ToString("F2") + " salários minimos");

    }
}