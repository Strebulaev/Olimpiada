/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static void Main() {
    var stringValue = Console.ReadLine();
    var n = int.Parse(stringValue);
    var t = n % 5;
    if (t == 0)
    {
        t = n / 5;
    }
    else
    {
        t = (n / 5) + 1;
    }
    Console.WriteLine(t);
  }
}