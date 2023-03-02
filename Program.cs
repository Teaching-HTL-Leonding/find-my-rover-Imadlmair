int West = 0;
int East = 0;
int South = 0;
int North = 0;
int end = 0;

WelcomeMessage();
void WelcomeMessage()
{
    Console.WriteLine("Welcome to FindMyRover");
}

Console.WriteLine("Enter the movement log of your rover!");
string Movement = Console.ReadLine()!;

East = Movement.Count(c => c == '>');
West = Movement.Count(c => c == '<');
North = Movement.Count(c => c == '^');
South = Movement.Count(c => c == 'V');

double all = East + West + North + South;
double length = Movement.Length;
if (all != length)
{
    Console.WriteLine("Error amk!");
    end = 1;
}
if (end == 0)
{
    double y = North - South;
    double x = East - West;
    double directWayLength = Math.Sqrt((y * y) + (x * x));
    Console.WriteLine("X =" + x);
    Console.WriteLine("Y =" + y);
    Console.WriteLine("Direct way =" + directWayLength);

}