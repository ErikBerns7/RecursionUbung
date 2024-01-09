Recursion(10);
//Methode die eine Zahl runterzählt ie von 10 auf 1 oder 99 auf 1
int Recursion(int number)
{
    Console.WriteLine(number);
    if (number == 1) return 1;
    return number = Recursion(number - 1);
}