using System;

namespace Delegate_Example
{
    // Declare the delegate here
    public delegate void StringDelegate( string text );

    class Program
    {
        static void Main( string[ ] args )
        {
            // Init StringDel member equal to function x
            StringDelegate strUpp = ToUpperCase;

            Console.WriteLine( "This is the UPPERCASE delegate function result" );
            strUpp( "=> this is now uppercase" );
            strUpp.Invoke( "=> also this too!" );

            StringDelegate strLow = ToLowerCase;

            Console.WriteLine( "\nTHIS IS THE lowercase DELEGATE FUNCTION result" );
            strLow( "==> this is now LOWERcase" );
            strLow.Invoke( "==> SAME AS THIS ONE\n" );

            strLow = ToUpperCase; // Set strLow to diff function
            strLow( "=> We have reassigned this delegate variable to strLow but to the Uppercase function!\n" );

            strLow = ToLowerCase; // Reset strLow back
            Writing( "This is some text", strUpp );

            Console.WriteLine();
            Writing1( "ALSO MORE TEXT", strLow );

            Console.ReadLine();
        }

        // Define a function(s) in same class
        static void ToUpperCase( string text ) => Console.WriteLine( text.ToUpper() );
        static void ToLowerCase( string text ) => Console.WriteLine( text.ToLower() );
        
        // Passing StringDelegate as an arguement in a function
        static void Writing(string text, StringDelegate strUpp )
        {
            Console.WriteLine( $"Before: {text}" );
            Console.Write( "After: " );
            strUpp( text );
        }
        static void Writing1( string text, StringDelegate strLow )
        {
            Console.WriteLine( $"Before: {text}" );
            Console.Write( "After: " );
            strLow( text );
        }

    }
}
