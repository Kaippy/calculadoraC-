namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora");
        Inicio:
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Operacao:
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("+ -> adição");
            Console.WriteLine("- -> subtração");
            Console.WriteLine("x -> multiplicação");
            Console.WriteLine("/ -> divisão");
            Console.WriteLine("F -> Sair");

            char operacao = char.Parse(Console.ReadLine().ToLower());

            double resultado = 0;
            switch (operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
                case '/':
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
                case 'f':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Caractere inválido, escolha novamente");
                    goto Operacao;
            }

            Console.WriteLine("Deseja fazer outra operaçao? Digite \"S\" caso sim ou pressione qualquer outra tecla caso não queira");
            string continuar = Console.ReadLine().ToLower();

            if (continuar == "s")
            {
                goto Inicio;
            }
            else
            {
                Console.WriteLine("Fim da operação");
            }
        }
    }
}
