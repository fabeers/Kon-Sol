

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
                        "1.1.0",
                        "-----",
                        "- Added 2 new commands for fun",
                        "- Recently put into beta release"
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
                
                default:
                    Console.WriteLine(inputValue + " is an Unknown command");
                    break;
            }
        }
    }
}