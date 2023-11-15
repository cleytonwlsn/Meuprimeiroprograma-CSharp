const string textoOlaMundo = "Olá mundo, meu primeiro programa C#! Feito por ";
string nomeCompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(textoOlaMundo + nomeCompleto + " que tem " + idade + " anos.");