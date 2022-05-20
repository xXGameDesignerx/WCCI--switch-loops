// switch

Console.WriteLine("Please give me a number 1-3");
string userinput = Console.ReadLine();
switch(userinput)
{
    case "1":
        // you can add another case
    case "one":
        Console.WriteLine("you choice the number 1");
        break;
    case "2":
        Console.WriteLine("you choice the number 2");
        break;
    case "3":
        Console.WriteLine("you choice the number 3");
        break;
    default:
        Console.WriteLine("Please choose a number between number 1-3");
        break;
}
//if statement syntax of our first case in the above switch case statement
if(userinput == "1" || userinput == "one")
{
    Console.WriteLine("you choice the number one");
}    
//cw + tab tab == this
Console.WriteLine();

// loops
bool condition = true;
if(condition)
{
    Console.WriteLine("condition is true");
}
// 3 poarts of a loop
// start 
//condition to check
// a way to stop the loop

/*//while
int x = 1036;
while (x >= 1)
{
    Console.WriteLine(x);
    x--;
}
while (x >= 1)
{
    Console.WriteLine(x);
    string stop = Console.ReadLine();
    if (stop == "y")
    {
        // the break will break out of the loop, but only do this by setting up a condition rather than break.
        break;
    }
}
while (x >= 1037)
{
    Console.WriteLine(x);
}

//do while loop
do
{
    Console.WriteLine(x);
} while (x >= 1037);
*/
//for loop
int num = 1;
while (num <=10)
{
    Console.WriteLine(num);
    num++;
}
// we do the same thing with a for loop
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
