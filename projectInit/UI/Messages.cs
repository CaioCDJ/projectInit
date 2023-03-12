using Spectre.Console;

namespace projectInit;

public class Messages{

  public static void showTitle(string title)
    => AnsiConsole.Write(
        new FigletText(title)
        .Centered());

  public static void Success(Project project){
  
    var table = new Table();

    table.Expand = true;
    
    table.Border(TableBorder.Rounded);
    table.BorderColor(Color.Green);
   
    table.AddColumn($"[blue]{ project.name }[/]");

    table.AddRow(new Markup("Project was created succesfully"));

    AnsiConsole.Write(table);  
  }

}
