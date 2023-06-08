class Exercicio2
{
    public static void main(){


        Console.WriteLine("[-------------------------------------]");
        Console.WriteLine("[          Calculadora de IMC         ]");
        Console.WriteLine("[-------------------------------------]");

        Console.WriteLine("Digite o seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        if(imc < 18.5){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está abaixo do peso");
        }

        if(imc >= 18.5 && imc < 24.9){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está está com peso normal");
        }

        if(imc >= 25.0 && imc < 29.0){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está com excesso de peso");
        }

        if(imc >= 30.0 && imc < 34.9){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está em obesidade classe I");
        }

         if(imc >= 35.0 && imc < 39.9){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está em obesidade classe II");
        }

         if(imc >= 40.0){
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));
            Console.WriteLine("Você está em obesidade classe III");
        }        
    }
}