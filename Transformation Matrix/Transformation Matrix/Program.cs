using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Transformation_Matrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello and welcome to the Transformation Matrix, The perfect sexifier! Please enter target's name");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Loading {0}.zip", name);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter {0}'s new name", name);
            string bname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Copying {0}.zip to {1}.zip", name, bname);
            Thread.Sleep(2000);
            Console.WriteLine("Applying {0}.zip to {1}", bname, name);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What type of transformation? (F2M or BE)");
            string transformation = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("Select Size bonus (Breast and Ass or Dick) also (small medium large)");
            string size = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("Select Inteligence (low normal high)");
            string intel = Console.ReadLine();
            Console.WriteLine("Waking up {0}", name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(5000);

            if (transformation == "BE")
            {
                BE(size, intel, name, bname);
            }
            else if (transformation == "F2M")
            {
                F2M(size, intel, name, bname);
            }




            Console.ReadLine();
        }
        static void BE(string size, string intel, string name, string bname)
        {
            Console.WriteLine("*YAWN* Hey, whats happening? whats with the laptop?");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Applying Physical Changes...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(3000);
            Console.WriteLine("Did you do something while I was asleep? My Bra feels...odd");
            Thread.Sleep(3000);
            if (size == "small")
            {
                Console.WriteLine("Like kinda tight, I should probably buy some bigger ones, damn");
            }
            else if (size == "medium")
            {
                Console.WriteLine("Ow Ow Ow! Its so tight now! *POP* Ah shit! Don't look!");
            }
            else if (size == "large")
            {
                Console.WriteLine("Ow Ow Ow! *POP* Ah shit! *Riiiip* NO Not my top! WTF is happening?!");
            }
            else
            {
                Console.WriteLine("Wait...My tits are gone! Wtf?! I'm flat!");
            }
            Thread.Sleep(2000);
            Console.WriteLine("Why are you just sitting there?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Applying Mental Changes...");
            Thread.Sleep(4000);
            Console.WriteLine("Changing name from {0} to {1} ", name, bname);
            Thread.Sleep(4000);
            Console.WriteLine("Changing IQ and Language to: {0}", intel);
            Thread.Sleep(4000);
            Console.WriteLine("What's your name?");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("My name is {0}", bname);
            Thread.Sleep(4000);
            if (intel == "high")
            {
                Console.WriteLine("This is...New? I assume you're doing this...");
                Thread.Sleep(3000);
                Console.WriteLine("Well these transformations will be perfect for making you cum for me");
                Thread.Sleep(3000);
                Console.WriteLine("Come here baby");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
            else if (intel == "low")
            {
                Console.WriteLine("Wow like...I feel so like...mmmf");
                Thread.Sleep(3000);
                if (size == "large")
                {
                    Console.WriteLine("My titties and ass are like so BIG!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with 'em! Like Oh yeahh");
                    Thread.Sleep(3000);
                }
                else if (size == "small")
                {
                    Console.WriteLine("My titties and ass are like chubby!!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I'm like...a model! You like smallish girls right?");
                    Thread.Sleep(3000);
                }
                else if (size == "medium")
                {
                    Console.WriteLine("My titties and ass are like inflated and so sensative and squishy!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with 'em! Like Oh yeahh");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("My titties and ass are like... Gone!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I'm like...a guy! You like flat girls right?");
                    Thread.Sleep(3000);
                }
                Console.WriteLine("Cm'ere, i'll put this body to good use");
                Thread.Sleep(3000);
                Console.WriteLine("Come here baby");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Wow like I'm so wet, what are you doing to me?");
                Thread.Sleep(3000);
                if (size == "large")
                {
                    Console.WriteLine("My boobs and ass are so BIG! I look like a bimbo!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with them though, they're so nice");
                    Thread.Sleep(3000);
                }
                else if (size == "small")
                {
                    Console.WriteLine("My bra and panties don't fit, have I been putting on weight?");
                    Thread.Sleep(3000);
                    Console.WriteLine("I don't know...I'm so horny");
                    Thread.Sleep(3000);
                }
                else if (size == "medium")
                {
                    Console.WriteLine("My boobs and ass have inflated! and oh my god so sensative and squishy!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with them!");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("My boobs and ass are gone!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I look like a guy! Why is this so hot though?!?!?");
                    Thread.Sleep(3000);
                }
                Console.WriteLine("I can't stop how horny I am! I just want you!");
                Thread.Sleep(3000);
                Console.WriteLine("Come here and take me!");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
        }
        static void F2M(string size, string intel, string name, string bname)
        {
            Console.WriteLine("*YAWN* Hey, whats happening? whats with the laptop?");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Applying Physical Changes...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(3000);
            Console.WriteLine("Did you do something while I was asleep? My Bra feels...odd");
            Thread.Sleep(3000);
            if (size == "small")
            {
                Console.WriteLine("Like it's just sitting there not holding anything, and my panties feel...tight");
            }
            else if (size == "medium")
            {
                Console.WriteLine("Ow Ow Ow! My panties, are so tight!");
            }
            else if (size == "large")
            {
                Console.WriteLine("Ow Ow Ow! *Riiiip* NO What the hell? Is that a...?");
            }
            else
            {
                Console.WriteLine("Wait...My tits are gone! Wtf?! I'm flat!");
            }
            Thread.Sleep(2000);
            Console.WriteLine("Why are you just sitting there?!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Applying Mental Changes...");
            Thread.Sleep(4000);
            Console.WriteLine("Changing name from {0} to {1} ", name, bname);
            Thread.Sleep(4000);
            Console.WriteLine("Changing IQ and Language to: {0}", intel);
            Thread.Sleep(4000);
            Console.WriteLine("What's your name?");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("My name is {0}", bname);
            Thread.Sleep(4000);
            if (intel == "high")
            {
                Console.WriteLine("This is...New? I assume you're doing...woah my voice is so deep");
                Thread.Sleep(3000);
                Console.WriteLine("I have a dick...oh fuck it's so hard I need to cum");
                Thread.Sleep(3000);
                Console.WriteLine("Come here baby");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
            else if (intel == "low")
            {
                Console.WriteLine("Wow like...my voice is so low and this thing between my legs");
                Thread.Sleep(3000);
                if (size == "large")
                {
                    Console.WriteLine("It's huge, like 7 Inches");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with it! Like it feels so good");
                    Thread.Sleep(3000);
                }
                else if (size == "small")
                {
                    Console.WriteLine("My voice is so low, but all i got was a micro penis?");
                    Thread.Sleep(3000);
                    Console.WriteLine("I'm so hard though...");
                    Thread.Sleep(3000);
                }
                else if (size == "medium")
                {
                    Console.WriteLine("My voice is so low now. And I have a dick?!");
                    Thread.Sleep(3000);
                    Console.WriteLine("Aw it's so hard.");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("My titties and ass are like... Gone!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I'm like...a guy! But with no sex organs or anything...");
                    Thread.Sleep(3000);
                    return;
                }
                Console.WriteLine("It's so hard to think, I just need to fuck...");
                Thread.Sleep(3000);
                Console.WriteLine("Come here baby");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Wow like I'm so wet and I have this bulge, what are you doing to me?");
                Thread.Sleep(3000);
                if (size == "large")
                {
                    Console.WriteLine("My boobs are gone and I have this BIG DICK! I look like magic mike!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with it, its so long and so nice");
                    Thread.Sleep(3000);
                }
                else if (size == "small")
                {
                    Console.WriteLine("panties don't fit,I have this bulge and its making me...");
                    Thread.Sleep(3000);
                    Console.WriteLine("I don't know...I'm so horny");
                    Thread.Sleep(3000);
                }
                else if (size == "medium")
                {
                    Console.WriteLine("My boobs are gone and I've grown a dick! and oh my god its so sensative!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I just wanna play with it!");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("My boobs and ass are gone!");
                    Thread.Sleep(3000);
                    Console.WriteLine("I look like a guy! Why is this so hot though?!?!?");
                    Thread.Sleep(3000);
                }
                Console.WriteLine("I can't stop how horny I am! I just need to cum!");
                Thread.Sleep(3000);
                Console.WriteLine("Come here and fuck me!");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Transformation Complete! Deleting {0}...", name);
                Thread.Sleep(3000);
            }
        }
    }
}
