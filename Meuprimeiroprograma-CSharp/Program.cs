const string textoOlaMundo = "Olá mundo, meu primeiro programa C#! Feito por ";
string nomeCompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

if (idade == 28 || nomeCompleto == "Cleyton Wilson") 
{
    Console.WriteLine(textoOlaMundo + nomeCompleto + " que tem " + idade + " anos.");
} else
{
    Console.WriteLine("Você digitou a idade e o nome errado.");
}
