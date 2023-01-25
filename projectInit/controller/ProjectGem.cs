using CliWrap;
using Spectre.Console;
using System.IO;

namespace projectInit;

public class ProjectGem{

  public async static Task newProject(Project project){ 
    await AnsiConsole.Status()
      .AutoRefresh(true)
      .Spinner(Spinner.Known.Arc)
      .SpinnerStyle(Style.Parse("green bold"))
      .StartAsync("[green]Creating the project[/]",async ctx=>{
        
        await defaultEstruc(project.name);
        AnsiConsole.Markup("Folder created...");
        Thread.Sleep(500);
        
        await Exec("dotnet",$"new {project.type} -o {project.name}/{project.name}");
        AnsiConsole.Markup("project Generated...");
        Thread.Sleep(500);
       
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
