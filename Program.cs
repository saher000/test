using Spectre.Console;
public class Program{
 public static void Main()
 {
    Console.ForegroundColor=ConsoleColor.Green;
    

   var table = new Table();

        // Add some columns
        table.AddColumn("Foo");
        table.AddColumn("Bar");

        // Add some rows
        table.AddRow("Baz", "Qux");
        table.AddRow("Corge", "Grault");
        table.AddRow("saher","ibrahim");
    table.BorderColor(Color.Aqua);

    AnsiConsole.Write(table);

    Console.WriteLine("hello saher");
    

 } 
}