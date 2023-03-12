using CliWrap;
using Spectre.Console;

namespace projectInit.projectGem;

public class GenericProject{

  public async static Task newProject(Project project){ 
    await AnsiConsole.Status()
      .Spinner(Spinner.Known.Arc)
      .SpinnerStyle(Style.Parse("blue bold"))
      .StartAsync("[blue]Creating the project[/]",async ctx=>{

        ctx.Status("[blue]Generating Folders...[/]");

        await GenericGemProcess.defaultEstruc(project.name);
        AnsiConsole.MarkupLine("[green]Folders Generated[/]");
  
        ctx.Status("[blue]Generating project[/]");
        await GenericGemProcess.Exec("dotnet",$"new { project.type } -o { project.name }/{ project.name }");
        AnsiConsole.MarkupLine("[green].Net Project Generated[/]");
       
        await GenericGemProcess.Exec("dotnet",$"sln {project.name}/{project.name}.sln add {project.name}/{project.name}");
        AnsiConsole.MarkupLine("[green]Solution Generated[/]");
        
        if(project.packages is not null){
          ctx.Status("[blue]Adding packages[/]");
          await GenericGemProcess.AddPackages(project);
          AnsiConsole.MarkupLine("[green]Packages Added[/]");
        }
        AnsiConsole.MarkupLine("[green]Project Generated[/]");  
    });
    Messages.Success(project);
  }
}
