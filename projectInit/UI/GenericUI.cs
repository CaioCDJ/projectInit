using Spectre.Console;

namespace projectInit;

public class GenericUi{

  public static string ask(string text){
    return AnsiConsole.Prompt(
      new TextPrompt<string>($"[blue]{text}: [/]")
    );
  }
  public static void showTitle(string title){

    var rule = new Rule($"[green]{title}[/]");
    rule.Justification = Justify.Left;
    AnsiConsole.Write(rule);
  }

}
