
namespace projectInit;

public class FriendlyMode{

  public async static Task handle(){

    string[] packages  = {
      "Spectre.Console",
      "Mediatr",
    };

    Project project = new Project();

    Dictionary<string,string> projectOptions = new Dictionary<string, string>();

    projectOptions.Add("Terminal based App [yellow](console)[/]",    "console");
    projectOptions.Add("Blank Web Api [yellow](web)[/]",             "web");
    projectOptions.Add("Web Api with Controller [yellow](webapi)[/]","webapi");
    projectOptions.Add("Blazor Client [yellow](blazorwasm)[/]",      "blazorwasm");
    projectOptions.Add("Blazor web server [yellow](blazorserver)[/]","blazorserver");
    
    projectOptions.Add("WebApplication [yellow](webapp/razor)[/]","webapp");
    projectOptions.Add("MVC WebApplication [yellow](mvc)[/]","mvc");

    string[] choices = projectOptions.Keys.ToArray();
 
    Messages.showTitle("Project Initializer");

    project.type = projectOptions[Menus.show(choices)];
    project.name = GenericUi.ask("Project name");

    // libs
    if(GenericUi.boolMenu("Do you want to add some packages?"))
      project.packages = Menus.showMulti(packages);

    await ProjectGem.newProject(project);
  }
}
