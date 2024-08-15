//Lista1
/*
int inteiro = 4;
float flutuante = 3.14f;
string text = "loucura";
bool booleando = 1>2;
Console.WriteLine(booleando);
Console.WriteLine(inteiro);
Console.WriteLine(text);
Console.WriteLine(flutuante);*/



//lista2
/*Console.WriteLine("Digite dois números inteiros.");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int adi = a+b;
int sub = a-b;
int mult = a*b;
int div = a/b;

Console.WriteLine(adi);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(div);*/

//lista3
/*
Console.WriteLine("Escreva seu nome de usuário e sua idade");
string nome = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"Olá {nome}, você tem {idade} anos de idade");*/


//lista4
/*Console.WriteLine("Digite seu número de usuário");
int us = int.Parse(Console.ReadLine());
if (us > 0){
    Console.WriteLine("Seu número de usuário é positivo");
}
else if(us == 0)
{
    Console.WriteLine("Seu número de usuário é zero");
}
else
{
    Console.WriteLine("Seu número de usuário é negativo");
}*/

//lista5
/*
for (int i = 0; i < 11; i++){
    Console.WriteLine(i);
}*/

//lista 6
/*
Console.WriteLine("Digite sua idade.");
int idade = int.Parse(Console.ReadLine());
if (idade > 17)
{
    Console.WriteLine("você é maior de idade e está apto(a) a votar e a dirigir");
}
else
{
    Console.WriteLine("Cresça");
}*/

//lista 7
/*
static void CalcularMedia(float nota1, float nota2, float nota3)
{
    float media = (nota1+nota2+nota3)/3;
    Console.WriteLine(media);
}
CalcularMedia(7.0f, 7.0f, 7.0f);*/

//lista 8 
/*
Console.WriteLine("Digite 3 números inteiros");
String[] numeros = Console.ReadLine().Split(',');
Array.Sort(numeros);
Console.WriteLine($"{numeros[0]} é o menor e {numeros[2]} é o maior");
*/

//lista 9
/*Console.WriteLine("Digite um número");
int num  = int.Parse(Console.ReadLine());
int aux = num;
int resultado = num;

while (aux > 0)
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    aux = num;
    resultado = resultado + num;
}
Console.WriteLine(resultado);*/

//lista 10
/*
Console.WriteLine("Digite um valor em reais");
double reais = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a cotação atual?");
double cotacao = double.Parse(Console.ReadLine());
double total = reais * cotacao;
Console.Write($"{total:F2}");*/
        

//lista 11 
/*
int CalcularFatorial (int n)
{
    if(n < 2|| n == 0 || n<0)
    {
        return 1;
    }
    else
    {
        return n * CalcularFatorial(n-1);
    }
}

Console.WriteLine("Digite um número maior que 2");
int num = int.Parse(Console.ReadLine());
Console.Write(CalcularFatorial(num));
*/