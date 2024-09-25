using DemoUnitTest;


Calcul calcul = new Calcul();
try
{
    Console.WriteLine(calcul.Addition(int.MaxValue, 10));

}
catch(Exception ex)
{
    Console.WriteLine("Une erreur s'est produite ");
}