using System;
class CalculadoraBasica {
  static void Main() {
    //string userName = Console.ReadLine();
    //Console.WriteLine("Username is: " + userName);
    Console.WriteLine("Qual operação deseja fazer ?\n\n[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[Enter] Sair do Programa\n\n");
    int nOperacao = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Escolha primeiro numero:");
    int n1 = Convert.ToInt32(Console.ReadLine()); 
    
    Console.WriteLine("Escolha o segundo numero:");
    int n2 = Convert.ToInt32(Console.ReadLine()); 
    int result;
    
    switch(nOperacao) 
        {
          case 1:
            result = n1 + n2;
            Console.WriteLine("O resultado é: " + result);
            break;
          case 2:
            result = n1 - n2;
            Console.WriteLine("O resultado é: " + result);
            break;
          case 3:
            result = n1 * n2;
            Console.WriteLine("O resultado é: " + result);
            break;
          case 4:
            result = n1 / n2;
            Console.WriteLine("O resultado é: " + result);
            break;
        }
  }
}