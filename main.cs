using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
   String nome, entrada;
    Double n1, n2, n3, media;

    Console.WriteLine("Digite o nome do aluno:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota:");
    entrada = Console.ReadLine();
    n1 = Double.Parse(entrada);
    Console.WriteLine("Digite a segunda nota:");
    entrada = Console.ReadLine();
    n2 =  Double.Parse(entrada);
    Console.WriteLine("Digite a terceira nota:");
    entrada = Console.ReadLine();
    n3 = Double.Parse(entrada);
    media = (n1*2) + (n2*3) + (n3*5)/10;
    Console.WriteLine("A média do(a) aluno(a) é: " + media);
    
    
    

    
    
  }
}