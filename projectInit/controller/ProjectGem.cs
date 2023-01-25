using CliWrap;
using Spectre.Console;

namespace projectInit;

public class ProjectGem{

  public async static Task newProject(Project project){ 
    await AnsiConsole.Status()
      .Spinner(Spinner.Known.Arc)
      .SpinnerStyle(Style.Parse("green bold"))
      .StartAsync("[blue]Creating the project[/]",async ctx=>{
        
        ctx.Status("[blue]Generating Folders...[/]");
        await defaultEstruc(project.name);
        AnsiConsole.MarkupLine("[green]Folders Generated[/]");

        Thread.Sleep(500); 

        ctx.Status("[blue]Generating project[/]");
        await Exec("dotnet",$"new { project.type } -o { project.name }/{ project.name }");
        AnsiConsole.MarkupLine("[green]Project Generated[/]");
        
    });

  }

  private async static Task defaultEstruc(string name){
  
    Directory.CreateDirectory(name);
     
    await Exec("dotnet", $"new sln -o {name}");

    await Exec("dotnet", $"new gitignore -o {name}");
    //await Exec("git", $"init {name}");
  }

  private async static Task Exec(string program, string args)
    => await Cli.Wrap(program)
      .WithArguments(args)
      .ExecuteAsync();

  // private async static Task AddLibs(){}

  // private async static Task DDD(){}
}
