Console.Write("\tEnter numbers of elements of array: ");
var n = int.Parse(Console.ReadLine());
var numbers= new int[n];
var rnd = new Random();
int i;
Console.Write("\tGiven elements of array: ");
for ( i = 0; i < n ; ++i)
{
    numbers[i] = rnd.Next(-20, 40);
    Console.Write(numbers[i]+"   ");
}
Console.Write("\tEnter numbers of elements of new array: ");
var count = int.Parse(Console.ReadLine());
Console.Write("\tBegins from which  elements of given array? ");
i=int.Parse(Console.ReadLine());

var array= new int[count];
Console.Write("\tGiven elements of newarray: ");
for ( var j = 0; j < count ; ++j)
{
    if (i + j > n - 1)
    {
        array[j] = 1;
    }
    else
    {
        array[j] = numbers[i + j];
    }
    Console.Write(array[j] + "   ");
    
}
