Console.Write("Enter base number: ");
int baseNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter power number: ");
int powNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(baseNum +" of power "+powNum+ " is " + GetPow(baseNum,powNum) );
Console.ReadLine();
static int GetPow(int baseNum, int powNum)
{
    int result = 1;
    for(int i = 0; i < powNum; i++)
    {
        result *= baseNum;
    }
    return result;
}