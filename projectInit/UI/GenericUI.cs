using Spectre.Console;

namespace projectInit;

public class GenericUi{

  public static string ask(string text){
    return AnsiConsole.Prompt(
      new TextPrompt<string>($"[blue]{text}: [/]")
    );
  }
}
