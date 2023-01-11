using System.Xml.Linq;

bool restart = true;

while (restart)
{
    int num = 0;
    while (num <= 1 || num > 1290)
    {
        Console.WriteLine("Please enter an integer");
        num = int.Parse(Console.ReadLine());
    }

    int squared = num * num;
    int cubed = num * num * num;

    /* Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Number", "Squared", "Cubed"));
     * 0=first quoted word(Number), 1=second quoted(Squared), 3=third quoted word(cubed)
     * -10=ten spaces given after that word, counted from left, starting with space after last character of word/number
     * 5=five spaces given before that word, counted from right, starting with space before the first character of word/number
     * negatives count from left, positives count from right
     */
    Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,5}", "Number", "Squared", "Cubed"));

    Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,5}", "======", "======", "======"));

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,5}", (i), (i * i), (i * i * i)));
    }
    Console.WriteLine("Continue? (y/n)");
    string answer = Console.ReadLine();

    if (answer == "y")
    {
        restart = true;
    }
    else
    {
        restart = false;
    }
}
