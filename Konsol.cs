using System;

public class Program {
    public static void Main(string [] args) {

        Console.WriteLine("Kon-Sol has Loaded! type 'util.help' for commands!");
        bool ConsoleActive = true;
        
        while (ConsoleActive = true)
        {
            Console.WriteLine("");
            Console.WriteLine("Kon-Sol Command Line");
            string inputValue = Console.ReadLine();
            Console.WriteLine("");
            
            switch (inputValue) {
                case "util.help": // Help Command
                    string[] helpOutput =
                    {
                        "Utility Commands :",
                        "-------------------",
                        "util.help - Displays the Commands",
                        "util.exit - exits console",
                        "util.print - prints a string of text given by the user",
                        "util.version - prints the current terminal version",
                        "util.consoleclear - clears the console of any other past commands",
                        "util.consolechangelog - gives you the changelog of the update",
                        "-------------------",
                        "Funny Commands : ",
                        "-------------------",
                        "fun.rickroll - gives you the rickroll youtube link",
                        "fun.greenconsole - makes your console green",
                        "fun.returnwhiteconsole - returns your console to white"
                    };
                        
                        foreach (string helpArrayOutput in helpOutput) {
                            Console.WriteLine(helpArrayOutput);
                    }
                    break;
                
                case "util.exit": // Utility Commands
                    Console.WriteLine("Exiting...");
                    Environment.Exit(102);
                    break;
                
                case "util.print":
                    Console.WriteLine("Input what you want to print here: ");
                    string printOutputValue = Console.ReadLine();
                    Console.WriteLine("Printed attribute : " + printOutputValue);
                    break;
                
                case "util.version":
                    Console.WriteLine("1.1.0 Beta Release");
                    break;
                
                case "util.consoleclear":
                    Console.Clear();
                    break;
                
                case "util.consolechangelog":
                    string[] changelogValue =
                    {
                        "1.2",
                        "-----",
                        "- Developer Mode has been added, if you want go find the key and the command"
                    };
                    
                    foreach (string changeLogArray in changelogValue) {
                        Console.WriteLine(changeLogArray);  
                        }
                    break;
                
                case "fun.rickroll": // Funny Commands
                    Console.WriteLine("Here you go: " + "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                    break;
                
                case "fun.greenconsole":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                
                case "fun.returnwhiteconsole":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                
                case "dev.util.developermode":
                    bool developerMode = true;
                    
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Insert the Developer Key please");
                    string developerPassword = Console.ReadLine();
                    
                    if (developerPassword == "DEVKEY192")
                    {
                        Console.WriteLine("Welcome to Developer-Mode");
                        
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Blue; // Knowing its in developermode
                        
                        while(developerMode = true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Developer Mode Command Line");
                            string developerInput = Console.ReadLine();
                            Console.WriteLine("");
                            
                            switch (developerInput)
                            {
                                case "dev.help":
                                    string[] developerHelp =
                                    {
                                        "dev.consoleInfo - project name, current version, what its built on etc etc",
                                        "dev.help - shows you the developer commands",
                                        "dev.logins - shows you the logins for developer mode",
                                        "dev.exit - self explanatory"
                                    };
                                    
                                    foreach (string devHelpArray in developerHelp)
                                    {
                                        Console.WriteLine(devHelpArray);
                                    }
                                    break;
                                case "dev.exit":
                                    break;
                                case "dev.consoleInfo":
                                    string[] developerConsoleInfo =
                                    {
                                        "Project Name - Venera",
                                        "Languages - CS",
                                        "Current Version - 1.2",
                                        "Development Team - fabee",
                                        "Current Name - Kon-SOL"
                                    };
                                    foreach (string devConsoleInfoArray in developerConsoleInfo)
                                    {
                                        Console.WriteLine(devConsoleInfoArray);
                                    }
                                
                                    break;
                                case "dev.logins":
                                    Console.WriteLine("'DEVKEY192' is the only current developer key");
                                    break;
                                default:
                                    Console.WriteLine("Who are you?");
                                    Environment.Exit(999);
                                    break;
                            }
                        }
                    }
                    break;
                
                default:
                    Console.WriteLine(inputValue + " is an Unknown command");
                    break;
            }
        }
    }
}