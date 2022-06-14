using Linecomparison2;
Class1 line= new Class1();

double line1= line.lengthofline(2, 4, 6, 7);
double line2= line.lengthofline(2, 4, 6, 7);

Console.WriteLine(line1);
Console.WriteLine(line2);

if (line1 == line2)
{
    Console.WriteLine("to equal");
}
else if (line1 < line2 )
{
    Console.WriteLine("line2 greater then line1");
}
else
{
    Console.WriteLine("line2 is less");
}


