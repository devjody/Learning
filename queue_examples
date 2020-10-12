using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {
        static void Main( string[ ] args )
        {
            Queue que = new Queue();
            que.Enqueue( 1 );
            que.Enqueue( 11 );
            que.Enqueue( 111);
            que.Enqueue( 1111 );
            que.Enqueue( 11111 );
            que.Enqueue( "A String - next is null" );
            que.Enqueue( null );
            que.Enqueue( true );
            que.Enqueue( false );

            Console.WriteLine( $"Number of Queued items = {que.Count}\n" );

            foreach ( var item in que )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine();

            Console.WriteLine( $"Peek => {que.Peek()}\n" );

            Console.WriteLine( $"Contains null? => {que.Contains( null )}\n" );

            while ( que.Count > 3 )
            {
                Console.WriteLine( $"Dequeue to remove from Top => {que.Dequeue()}" );
            }

            foreach ( var item in que )
            {
                Console.WriteLine( item );
            }
            Console.ReadLine();
        }
    }
}
