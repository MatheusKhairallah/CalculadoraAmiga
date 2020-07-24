using System;

namespace CalculadoraAmiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, meu nome é Zayn! Hoje serei sua calculadora, vamos começar!!!");
            Console.WriteLine("Primeiro de tudo preciso saber seu nome");
            Console.Write("Digite seu nome: ");
            string nome=Console.ReadLine();
            
            Console.Clear();
            Console.Write("Prazer em conhece-lo " + nome + "\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(nome + " eu tenho uma lista de seis operações matemáticas que são elas:\nSoma; Subtração; Multiplicação\nDivisão; Raiz Quadrada e Potência");
            Console.Write("Escolha uma das seis e então poderemos começar a calcular!\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            
            string sair;
            do
            {
                
                Console.Write(nome + " Digite uma das operações matemáticas da lista: ");
                string operação=Console.ReadLine().ToLower();
                
                if(operação=="soma")
                Program.CalcularSoma();          
                
                else if(operação=="subtração")
                Program.CalcularSubtração();
                
                else if(operação=="multiplicação")
                Program.CalcularMultiplicação();
                
                else if(operação=="divisão")
                Program.CalcularDivisão();
                
                else if(operação=="raiz quadrada")
                Program.CalcularRaizQuadrada();
                
                else if(operação=="potência")
                Program.CalcularPotênciação();
                
                else
                Console.WriteLine(nome + " você não digitou nenhuma das operações da lista ou deve ter digitado errado");

                Console.Write("Deseja parar de calcular, SIM ou NÃO: ");
                sair=Console.ReadLine().ToUpper();
                Console.Clear();

            
            } while (sair != "SIM" && sair != "S");

            Console.Write("Deseja ver os créditos do programa?: ");
            string resposta=Console.ReadLine().ToLower();

            if(resposta == "sim" || resposta == "s")
            Console.WriteLine("Prazer " +nome+ " meu nome é Matheus e eu sou o criador deste programa.\nFiz este programa com a intenção de ajudar pessoas como você\na resolver contas simples de matemática.\nSe tiver interesse aqui está o link do site do meu projeto: https://github.com/MatheusKhairallah/CalculadoraAmiga\nPressione qualquer tecla para continuar");

            else
            Console.WriteLine("OK, então pressione qualquer tecla para continuar");
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("Obrigrado " + nome + " por usar a calculadora!\nAté a próxima!\nPressione qualquer tecla para finalizar");
            Console.ReadKey();
            
        }

        static void CalcularSoma()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("1° número: ");
            double valor1=Convert.ToDouble(Console.ReadLine());
            Console.Write("2° número: ");
            double valor2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{valor1} + {valor2} = " + (valor1+valor2));

        }

        static void CalcularSubtração()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("1° número: ");
            double valor3=Convert.ToDouble(Console.ReadLine());
            Console.Write("2° número: ");
            double valor4=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{valor3} - {valor4} = " + (valor3-valor4)); 
        }

        static void CalcularMultiplicação()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("1° número: ");
            double valor5=Convert.ToDouble(Console.ReadLine());
            Console.Write("2° número: ");
            double valor6=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{valor5} X {valor6} = " + (valor5*valor6));
        }

        static void CalcularDivisão()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("1° número: ");
            double valor7=Convert.ToDouble(Console.ReadLine());
            Console.Write("2° número: ");
            double valor8=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{valor7} / {valor8} = " + (valor7/valor8));
        }

        static void CalcularRaizQuadrada()
        {
            Console.WriteLine("Digite um número");
            Console.Write("1° número: ");
            double valor9=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A raiz quadrada de {valor9} é = " + (Math.Sqrt(valor9)));
        }

        static void CalcularPotênciação()
        {
            Console.WriteLine("Digite dois números");
            Console.Write("1° número: ");
            double valor10=Convert.ToDouble(Console.ReadLine());
            Console.Write("2° número: ");
            double valor11=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{valor10} elevado a {valor11} é = " + (Math.Pow(valor10, valor11)));
        }

    }

}
