/*******************VITOR*******************/
//Vitor você vai fzer o codigo para o usuario digitar e guardar na variével
//vão ser dois numeros digite o primeir depois digite o segundo.

/*******************Alexandre*******************************************/
//Alexandre vai escrever o codigo das operações operações
//matemática soma, subtração, divisão e multiplicação

/**************************************************************/

/************************Renan**************************************/
//Vai verificar se os codigos etão corretos e fazer o código
//que vai mostrar o resultado da operaçã matemática///

 
 
int numero1 = 0; 
int numero2 = 0;

string operador = null!;

Console.WriteLine("Calculadora de 4 operações");
Console.WriteLine("Digite o primeiro numero a ser calculado");
Console.WriteLine("Digite o segundo numero a ser calculado");
Console.WriteLine("Digite o operador matematico + para soma");
Console.WriteLine("Digite o operador matematico - para subtração");
Console.WriteLine("Digite o operador matematico / para divisão");
Console.WriteLine("Digite o operador matematico * para multiplicação");

numero1 = Convert.ToInt32(Console.ReadLine());
numero2 = Convert.ToInt32(Console.ReadLine());
operador = Console.ReadLine()!;

if(operador == "+"){
Console.WriteLine (numero1 + numero2);
 
 
}

else if(operador == "/"){
Console.WriteLine (numero1 / numero2); //aaaaaaaa


}

else if(operador == "-"){
Console.WriteLine (numero1 - numero2);
}
