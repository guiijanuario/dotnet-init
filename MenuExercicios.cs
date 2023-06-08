using System;

public class MenuExercicios {

    public static void Main (String[] args){

        Console.WriteLine("Insira o número do exericicio que deseja executar");
        Console.WriteLine("Exercício 1");
        Console.WriteLine("Exercício 2");
        Console.WriteLine("Exercício 3");
        Console.WriteLine("Exercício 4");
        int exercicio = Convert.ToInt32(Console.ReadLine());
    
        switch (exercicio){
            case 1:
                Exercicio1.main();
                break;
            case 2:
                Exercicio2.main();
                break;
            case 3:
                Exercicio3.main();
                break;
            case 4:
                Console.WriteLine("Exercício 4");
                break;
            default:
                Console.WriteLine("Número Inválido");
                break;
            }
    }
}