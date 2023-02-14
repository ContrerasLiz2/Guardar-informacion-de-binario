// See https://aka.ms/new-console-template for more information

int dato = 300;
Console.Write("El binario es :");
Console.WriteLine(Convert.ToString(dato,2));
Console.Write("En hexadecimal es : ");
Console.WriteLine(Convert.ToString(dato, 16));

Console.Write("Dime un dato binario :");
Console.WriteLine("En deciaml es : {0}");
   Convert.ToUInt32(Console.ReadLine(), 2 );
Console.WriteLine("En deciaml es : {0}");
Convert.ToUInt32(Console.ReadLine(), 16);



//Hcaer un programa que muestre el siguiente menu introducir un numero deciaml , un enumero binarion , un numero hexadeciaml
//dependiemndo de la opcion es el dato que se va a solicitar  Para realizar las siguienes operaciones
//1 - Si es decimal se elevara la cuadrado y
//su resultado de mostrara en binario y hexadeciamal .
//2 - Si es binario se sumara el resultado del cudrado del mismo y se mostrara en decimal y hexadecimal 
// 3- Si el valor es hedaxecimal se mostrara su tabla de multiplicar , esta tabla seria en Hexadecimal exclusivamente 