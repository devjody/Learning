/* C# - Stack<T>
Stack is a special type of collection that stores elements in LIFO style (Last In First Out). C# includes the generic Stack<T> and non-generic Stack collection classes. It is recommended to use the generic Stack<T> collection.

Stack is useful to store temporary data in LIFO style, and you might want to delete an element after retrieving its value. 

Source: https://www.tutorialsteacher.com/csharp/csharp-stack */

using System;
using System.Collections;

namespace StackExample
{
    public class Stacktools
    {
        public static void Length( Stack stack )
        {
            Console.WriteLine( $"Stack Length is = { stack.Count}" );
        }
        public static void Peeker( Stack stack )
        {
            Console.WriteLine( $"Peak the stack = { stack.Peek()}" );
        }
    }
    class Program
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine( "--- Some Examples of Stack (non-gen) ---" );
            Stack stack = new Stack(); // Creates new stack class

            // stack.Push() will add items to top of stack
            stack.Push( "Hi, Btm Of Stack" );
            stack.Push( 4 );
            stack.Push( 3 );
            stack.Push( 2 );
            stack.Push( "Hi, Top Of Stack" );
            Console.WriteLine( "--------------\n" );
            // Loop the stack to console out
            foreach ( var n in stack )
            {
                Console.WriteLine( n );
            }
            Console.WriteLine( "--------------\n" );

            Stacktools.Length(stack); // stack.Count
            Console.WriteLine( "--------------\n" );

            Stacktools.Peeker(stack); // stack.Peek()
            Console.WriteLine( "--------------\n" );

            Console.WriteLine( stack.Pop() );
            // stack.Pop() removes the top of stack item

            // Loop the stack to console out again
            foreach ( var n in stack )
            {
                Console.WriteLine( n );
            }
            Console.WriteLine("--------------\n");

            // Now lets peek the top again
            Stacktools.Peeker( stack );

            // Add some more to the stack
            stack.Push( "OMG it's Snowing!" );
            Console.WriteLine( "--------------\n" );

            for ( int i = 0; i < 1; i++ )
            {
                Console.WriteLine( stack.Peek() );
            }
            Console.WriteLine( "--------------\n" );

            stack.Push( "Snow" );

            // Check to see if the stack contains something?
            Console.WriteLine( $"Oh yeah this is [{stack.Contains( "Snow" )}] baby!\n" );

            // stack.Clear()
            stack.Clear();

            // Loop the stack to console out finally
            foreach ( var n in stack )
            {
                Console.WriteLine( n );
            }
            Console.WriteLine( "--------------\n" );

            // stack.Count after using stack.Clear()
            Stacktools.Length( stack ); 
            Console.ReadLine();
        }
    }
}
