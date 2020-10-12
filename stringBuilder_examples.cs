using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {

        string hello = "Hello World";
        var hi = hello;
        hello = "Hi There";
        Console.WriteLine( ReferenceEquals(hello, hi));

        StringBuilder stringbuild = new StringBuilder(" Hello again, ");
        var sbuild = stringbuild;
        stringbuild.Append("another string to add");
        Console.WriteLine(ReferenceEquals(sbuild,stringbuild));

        StringBuilder sbApp = new StringBuilder();

        sbApp.Append(3);
        sbApp.Append("+");
        sbApp.Append(6);
        Console.WriteLine(sbApp.Length);

        sbApp.Insert(3, "="); // index, string
        Console.WriteLine(sbApp);

        sbApp.Remove(1, 2); // index, chars
        Console.WriteLine(sbApp);

        sbApp.Replace("3", "7"); // replace string, with
        Console.WriteLine(sbApp);
  }
}
