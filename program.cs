using System;
using Cosmos.Compiler.Builder;
using Cosmos.Hardware;
using Cosmos.Sys.FileSystem;
using Cosmos.Kernel;
using Cosmos.Kernel.ManagedMemory;
namespace ThunderOS
{
    class Program
    {
        #region Cosmos Builder logic
        // Most users wont touch this. This will call the Cosmos Build tool
        [STAThread]
        static void Main(string[] args)
        {
            BuildUI.Run();
        }
        #endregion

        // Main entry point of the kernel
        public static int i = 0;
        public static void Init()
        {
            var xBoot = new Cosmos.Sys.Boot();
            xBoot.Execute();


            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            string ret = "";
            int parseline = 1;
            int i = 0;
            int line = 0;
            string ln1 = "";
            string ln2 = "";
            string ln3 = "";
            string ln4 = "";
            string ln5 = "";
            string ln6 = "";
            string ln7 = "";
            string ln8 = "";
            string ln9 = "";
            string ln10 = "";
            string ln11 = "";
            string ln12 = "";
            string aline = "";
            string ln = "";
            string scriptln = "";
        a:
            i++;
            if (i < 1000000)
            {
                goto a;

            }
            i = 0;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            b:
            i++;
            if (i < 1000000)
            {
                goto b;
            }
            i = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            c:
            i++;
            if (i < 1000000)
            {
                goto c;
            }
            i = 0;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        d:
            i++;
            if (i < 1000000)
            {
                goto d;
            }
            i = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        e:
            i++;
            if (i < 1000000)
            {
                goto e;
            }
            //------------------------[OS START]-------------------------------
            begin:
            Console.WriteLine("              Lightning OS");
            Console.WriteLine("       Presented by Nimbosoft");
            Console.WriteLine("Do you want to see the 'Commands' message?(y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("ABOUT: Will show the user manual and explain how to use LightningOS; COMMANDS:  Will show this message; PROGRAMMING_COMMANDS: Will show all of the possible waysto use the ThunderScript language; PROGRAM: Allows the user to create a simple  12-line max program using ThunderScript; RUN: Runs the program file created by  using the 'Program' command; CLS: Clears the screen; WRITEFILE: Writes text to avirtual file until the user inputs 'finish' on its own line; READFILE: Prints   the text of the virtual file to the screen; LOGOFF: Will log off the user;");
            }

            loop:
            Console.WriteLine("Password:");
            string password = Console.ReadLine().ToLower();
            if (password == "isoterrania")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                goto initialize;
             
            }
            else
            {
                goto loop;
            }

        initialize:
            //----------------------[Main Loop]--------------------------------
    
         
     
       
    
            //-----------------------------------------------------------------
           
            rl:
                    string cmd = Console.ReadLine().ToLower();
            if (cmd == "writefile")
            {
                ln = "";
                goto fledit;
            }
            if (cmd == "readfile")
            {
                ln = ln.Substring(0, ln.Length - 80);
                Console.WriteLine(ln);
            }
            if (cmd == "cls")
            {
                Console.Clear();
            }
            if (cmd == "run")
            {
                goto run;
            }
            if (cmd == "commands")
            {
                Console.WriteLine("ABOUT: Will show the user manual and explain how to use LightningOS; COMMANDS:  Will show this message; PROGRAMMING_COMMANDS: Will show all of the possible waysto use the ThunderScript language; PROGRAM: Allows the user to create a simple  12-line max program using ThunderScript; RUN: Runs the program file created by  using the 'Program' command; CLS: Clears the screen; WRITEFILE: Writes text to avirtual file until the user inputs 'finish' on its own line; READFILE: Prints   the text of the virtual file to the screen; LOGOFF: Will log off the user;");
            }
            if (cmd == "programming_commands")
            {
                Console.WriteLine("'PRINT ' and 'PRINTLN ' will print text tothe screen; 'RETURN' will read a line inputted by the user; 'CLEAR' will clear the screen; 'PAUSE' will wait for the  user to press 'ENTER', and then continue; 'WRITEFILE ' will write the text afterthe command to the virtual file; 'READFILE' will print the text of the file  to the screen; 'PRINTRETURN' and 'PRINTRETURNLN' will print the value of the       'RETURN' line");
            }
            if (cmd == "about")
            {
                Console.WriteLine();
            }
            if (cmd == "program")
            {
                line = 0;
                parseline = 1;
                goto script;
            }
            if (cmd == "logoff")
            {
                Console.Clear();
                goto begin;
            }
            goto rl;
        fledit:
            int lnnum = 1;
            
            string deltaln = Console.ReadLine();
            deltaln = deltaln + "                                                                                ";
            deltaln = deltaln.Substring(0, deltaln.Length + (80 - deltaln.Length));
            ln = ln + deltaln;
            


            if (deltaln != "finish                                                                          ")
            {
                goto fledit;
            }
            goto rl;
        script:
            //-------------------------------------------------------------------------------------------[what line is the user on?]---------------
            line++;
            if (line == 1)
            {
                ln1 = Console.ReadLine();
                aline = ln1;
            }
            if (line == 2)
            {
                ln2 = Console.ReadLine();
                aline = ln2;
            }
            if (line == 3)
            {
                ln3 = Console.ReadLine();
                aline = ln3;
            }
            if (line == 4)
            {
                ln4 = Console.ReadLine();
                aline = ln4;
            }
            if (line == 5)
            {
                ln5 = Console.ReadLine();
                aline = ln5;
            }
         
            if (line == 6)
            {
                ln6 = Console.ReadLine();
                aline = ln6;
            }
            if (line == 7)
            {
                ln7 = Console.ReadLine();
                aline = ln7;
            }
            if (line == 8)
            {
                ln8 = Console.ReadLine();
                aline = ln8;
            }
            if (line == 9)
            {
                ln9 = Console.ReadLine();
                aline = ln9;
            }
            if (line == 10)
            {
                ln10 = Console.ReadLine();
                aline = ln10;
            }
            if (line == 11)
            {
                ln11 = Console.ReadLine();
                aline = ln11;
            }

            if (line == 12)
            {
                ln12 = Console.ReadLine();
                aline = ln12;
            }
            if (line < 12)
            {
                goto script;
            }
            goto rl;

        run:
            if (parseline == 1)
            {
               
                aline = ln1;
                parseline++;
                goto compile;
            }
            if (parseline == 2)
            {
             
                aline = ln2;
                parseline++;
                goto compile;
            }
            if (parseline == 3)
            {
 
                aline = ln3;
                parseline++;
                goto compile;
            }
            if (parseline == 4)
            {
        
                aline = ln4;
                parseline++;
                goto compile;
            }
            if (parseline == 5)
            {
           
                aline = ln5;
                parseline++;
                goto compile;
            }
            if (parseline == 6)
            {
         
                aline = ln6;
                parseline++;
                goto compile;
            }
            if (parseline == 7)
            {
            
                aline = ln7;
                parseline++;
                goto compile;
            }
            if (parseline == 8)
            {
         
                aline = ln8;
                parseline++;
                goto compile;
            }
            if (parseline == 9)
            {
      
                aline = ln9;
                parseline++;
                goto compile;
            }
            if (parseline == 10)
            {
      
                aline = ln10;
                parseline++;
                goto compile;
            }
            if (parseline == 11)
            {
          
                aline = ln11;
                parseline++;
                goto compile;
            }
            if (parseline == 12)
            {
   
                aline = ln12;
                parseline++;
                goto compile;
            }
            if( parseline > 12 )
            {
            goto rl;
        }
        compile:
 
             if (aline.StartsWith("print "))
             {
                 Console.Write(aline.Substring(6));
             }
            else if (aline == "clear")
            {
                Console.Clear();
            }
            else if (aline.StartsWith("writefile "))
            {
                Console.WriteLine(aline.Substring(10));
            }
            else if (aline == "readfile")
            {
                Console.WriteLine(ln);
            }
            else if (aline == "return")
            {
                 ret = Console.ReadLine();
            }
            else if (aline.StartsWith("pause"))
            {
                Console.ReadLine();
            }
            else if (aline.StartsWith("println "))
            {
                Console.WriteLine(aline.Substring(8));
            }
            else if (aline.StartsWith("printreturn"))
            {
                Console.Write(ret);
            }
            else if (aline.StartsWith("printreturnln"))
            {
                Console.WriteLine(ret);
            }
          
                goto run;
            
            while (true)
                ;
        }

        
    }
}   
