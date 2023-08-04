using System;

class Program {
  public static void Main ()
  {
      bool sair = false;

    while(!sair)
    {
      Console.WriteLine("Diga qual operação quer realizar:\n1. soma\n2. subtração\n3. multiplicação\n4. divisão\n5. Sair");
        string operacao = Console.ReadLine();

        if(operacao == "1")
      {
       Console.WriteLine("Digite o primeiro valor");
       int primeiroValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
       int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado:" + (primeiroValor + segundoValor));
      }
      else if(operacao == "2")
        {
          Console.WriteLine("Digite o primeiro valor");
       int primeiroValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
       int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado:" + (primeiroValor - segundoValor));
          
        }

      else if(operacao == "3")
          {
            Console.WriteLine("Digite o primeiro valor");
       int primeiroValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
       int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado:" + (primeiroValor * segundoValor));
          }
      else if(operacao == "4")
          {
            Console.WriteLine("Digite o primeiro valor");
       int primeiroValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
       int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado:" + (primeiroValor / segundoValor));
          }
      else if(operacao == "5")
      {
        sair = true;
        Console.Clear();
      }
      else
      {
      Console.WriteLine("Digite uma operação valida");  
      }
      Console.WriteLine("Obrigado por usar esta calculadora.");
    }
  }
}
