// See https://aka.ms/new-console-template for more information


int myNum = 0;
int mynum2 = 0;

//Taking input for 1st num
Console.WriteLine("Enter a whole num: ");


string userInput = Console.ReadLine();
myNum = int.Parse(userInput);

Console.WriteLine("Enter the 2nd whole num: ");
userInput = Console.ReadLine();
mynum2 = int.Parse(userInput);

int sum = myNum + mynum2;
Console.WriteLine("The result of "+myNum+"is"+sum);




//String interpolation
Console.WriteLine($"The result of {myNum}and {mynum2} is {sum}");//less error prone  
Console.ReadKey();