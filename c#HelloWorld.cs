using System;

class Program {
    static void Main(string[] args) {
      int number;
      number = 1;
      
      //Camel case
      byte phoneNumber = 255;
      phoneNumber +=1;
      //Pascal case
      const float Pi = 3.14f;
      {
        int scope = 145;
      }

      
        Console.WriteLine(phoneNumber);
        phoneNumber +=1;
        Console.WriteLine(number);
        Console.Write(Pi);
    }
}
