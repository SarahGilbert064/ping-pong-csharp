using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    // Console.WriteLine("Hello world");
    string[] myPingPong = { "1", "2", "ping", "4", "pong" };

    Console.WriteLine("User input is: ");
    for (int i = 0; i < myPingPong.Length; i++)
    {
      Console.WriteLine(myPingPong[i]);
    }
  }
}