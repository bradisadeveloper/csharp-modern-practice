using Spectre.Console;

AnsiConsole.MarkupLine("[bold yellow]My Garage Goals[/]");

//var table = new Table();
//table.AddColumn("Car");
//table.AddColumn("Horsepower");
//table.AddColumn("Status");

//table.AddRow("Mazda MX-5 Miata", "116", "[blue]My current car[/]");
//table.AddRow("Lamborghini Gallardo Superleggera", "517", "[red]Dream car[/]");

//AnsiConsole.Write(table);

public record Car(string Make, string Model, int Horsepower, int price, string Status);
public record Property(string street, string city, string state, int zip, int price, string status);