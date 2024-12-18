
#region Functions 
// Task 1 Function 
using System.ComponentModel.Design;

string Greet(string name)
{
    return "Welcome " + name + " !";    
}

// Task 2 Function 
int Volume (int length, int width, int height)
{
    return length * width * height;
}

// Task 3 Function 
int EvenOdd (int input)
{
    if (input % 2 == 0)
    {
        return input * input;
    }
    else 
    {
        return input * 2;
    }
}

// Task 4 Function 
int CtoF (int temp)
{
    return (temp * 9 / 5) + 32;
}

// Task 5 Function 
string VorC (char letter)
{
    if (!(char.IsLetter(letter)))
    {
        return "not a letter!";
    }
    else if (letter=='a' ||  letter =='e' || letter == 'i' || letter == 'o' || letter == 'u' || letter =='y' || 
        letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
    {
        return "vowel";
    }
    else { 
        return "constant";
    }  
}

// Task 6 Function 
double Conversion (double rate, double kwd)
{
    return rate * kwd;
}
#endregion 


#region Tasks 
// Task 1 
Console.WriteLine("Hello, Please enter your name :");
string name = Console.ReadLine();
Console.WriteLine(Greet(name));

Console.WriteLine("--------------------------------");

// Task 2 
Console.WriteLine("Calculating Volume of a box ");

Console.WriteLine("Enter Length : ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width : "); 
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height : ");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The Volume Of The Box Is :" + Volume(length, width, height) + " CM^3");

Console.WriteLine("--------------------------------");

// Task 3 

Console.WriteLine("Please input number :");
int input  = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Result is = " + EvenOdd(input));

Console.WriteLine("--------------------------------");

// Task 4 

Console.WriteLine("Please input temperature in celcius :");
int temp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Temperature in Farenheit is = " + CtoF(temp));

Console.WriteLine("--------------------------------");

// Task 5 

Console.WriteLine("Please input letter to check if vowel or constant");
char letter = Convert.ToChar(Console.ReadLine());
Console.WriteLine("The letter is a " + VorC(letter));

Console.WriteLine("--------------------------------");

// Task 6 

Console.WriteLine("Please input conversion amount : ");
double kwd = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input currency of original amount : ");
string currency = Console.ReadLine();   

Console.WriteLine("Please input conversion rate :");
double rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input currency of converted amount : ");
string second = Console.ReadLine();

Console.WriteLine("Your converted amount from " + currency + " to " + second + " is = " + Conversion(rate, kwd) + second);

#endregion