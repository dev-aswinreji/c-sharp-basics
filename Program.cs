using System;

class Program 
{
  static void Main(string[] args)
  {

    // console.writeline("hello, world!");
    // int age = 25;
    // double salary = 5000.50;
    // char grade = 'a';
    // bool isstudent = true; 
    // string name = "jude";
    //
    // console.write($"{age} \n{salary} \n{grade} \n{isstudent} \n{name}");
    // Console.ReadKey(); // Waits for a key press
    // Console.Write("Enter your name: ");
    // string name = Console.ReadLine();
    //
    // Console.Write("Enter your age: ");
    // int age = Convert.ToInt32(Console.ReadLine());
    //
    // Console.WriteLine($"Hello {name}, you are {age} years old!");


    // This method is properly working but we need to catch erros such as if user input other values instead of numbers
    
    // Console.Write("Enter number: ");
    // int num1 = Convert.ToInt32(Console.ReadLine());
    //
    // Console.Write("Enter number: ");
    // int num2 = Convert.ToInt32(Console.ReadLine());
    //
    // int sum = num1 + num2;
    // Console.WriteLine($"Sum is {sum}");

  //   Console.Write("Enter first number: ");
  //   if(!int.TryParse(Console.ReadLine(), out int num1))
  //   {
  //       Console.WriteLine("Invalid input!");
  //       return;
  //   }
  //
  //   Console.Write("Enter second number: ");
  //   if(!int.TryParse(Console.ReadLine(), out int num2))
  //   {
  //     Console.WriteLine("Invalid input!");
  //     return;
  //   }
  //
  //   int sum = num1 + num2;
  //   Console.WriteLine($"Sum is {sum}");
  // }


  // Logical Operator 
  // Equal to ==
  // Not Equal !=
  // Greater than > 
  // Less than < 
  // Greater or equal >=
  // Less or equal <=
  // AND && 
  //
  
  
  // Check if number is Positive

  Console.Write("Enter a number: ");
  if(int.TryParse(Console.ReadLine(),out int num))
  {
    if( num > 0 ){
      Console.Write("Num is positive");
    }else if(num < 0){
      Console.Write("Num is negative");
    }else
    {
     Console.Write("Num is Zero");   
    }

  }else {
     Console.Write("Invalid Input!");
     return;
  }
}

}




