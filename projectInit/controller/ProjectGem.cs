using CliWrap;
using Spectre.Console;

namespace projectInit;

public class ProjectGem{

  public async static Task newProject(Project project){ 
    await AnsiConsole.Status()
      .Spinner(Spinner.Known.Arc)
      .SpinnerStyle(Style.Parse("green bold"))
      .StartAsync("[blue]Creating the project[/]",async ctx=>{
      .StartAsync("[blue]Creating the project[/]",async ctx=>{
        
        ctx.Status("[blue]Generating Folders...[/]");
        ctx.Status("[blue]Generating Folders...[/]");
        await defaultEstruc(project.name);
        AnsiConsole.MarkupLine("[green]Folders Generated[/]");
       
        ctx.Status("[blue]Generating project[/]");
        await Exec("dotnet",$"new { project.type } -o { project.name }/{ project.name }");
 
        await Exec("dotnet",$"sln {project.name}/{project.name}.sln add {project.name}/{project.name}");

        AnsiConsole.MarkupLine("[green]Project Generated[/]");  
    });
    Messages.Success(project);
  }

  private async static Task defaultEstruc(string name){
  
    Directory.CreateDirectory(name);
     
    await Exec("dotnet", $"new sln -o {name}");


    await Exec("dotnet", $"new gitignore -o {name}");
  }

  private async static Task Exec(string program, string args)
    => await Cli.Wrap(program)
      .WithArguments(args)
      .ExecuteAsync();

  //private async static Task AddLibs(string[] packages){  };

  // private async static Task DDD(){}
}
