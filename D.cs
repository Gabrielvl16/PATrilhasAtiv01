using System;

class Program
{
    static void Main()
    {
    	// Pedindo para o úsuario digitar sim ou não
    	Console.WriteLine("Digite sim ou não:");
    	
    	// Verificando se é true ou false
        bool resposta = Console.ReadLine().ToLower() == "sim";
        
        // Imprimindo resultado
        Console.WriteLine(resposta);
        
        Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
