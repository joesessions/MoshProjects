using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "a"; string title; string descrip;
            Console.WriteLine("STACKOVERFLOW SINGULAR");
            Console.WriteLine();

            while (input != "Q")
            {
                Console.WriteLine("Enter C to create a new post.");
                Console.WriteLine("Enter U to upvote it.");
                Console.WriteLine("Enter D to downvote it.");
                Console.WriteLine("Enter Q to quit.");

                input = Console.ReadLine();
                Post post = new Post();

                if (input == "C")
                {

                    Console.WriteLine("Enter the title");
                    Console.WriteLine();
                    title = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the description");
                    descrip = Console.ReadLine();
                    post.postCreate(title, descrip);
                    Console.WriteLine("Thank you");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Here's your post: ");
                    Console.WriteLine(post.Title);
                    Console.WriteLine();
                    Console.WriteLine(post.Description);
                    Console.WriteLine();
                    Console.WriteLine(post.Votes);
                }

                if (input == "U")
                {
                    post.postUpVote();
                    Console.WriteLine("Thank you");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Here's your post: ");
                    Console.WriteLine(post.Title);
                    Console.WriteLine();
                    Console.WriteLine(post.Description);
                    Console.WriteLine();
                    Console.WriteLine(post.Votes);
                }

                if (input == "D")
                {
                    post.postDownVote();
                    Console.WriteLine("Thank you");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Here's your post: ");
                    Console.WriteLine(post.Title);
                    Console.WriteLine();
                    Console.WriteLine(post.Description);
                    Console.WriteLine();
                    Console.WriteLine(post.Votes);
                }
            }

            
        }
    }
}
