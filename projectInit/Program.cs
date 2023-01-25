using projectInit;

public class Program{

  public async static Task Main(string[] args) {
    Console.Clear();

    Project project = new Project();

    Dictionary<string,string> projectOptions = new Dictionary<string, string>();

    projectOptions.Add("Terminal based App [yellow](console)[/]","console");
    projectOptions.Add("Blank Web Api [yellow](web)[/]","web");
    projectOptions.Add("Web Api with Controller [yellow](webapi)[/]","webapi");
    projectOptions.Add("Blazor Client [yellow](blazorwasm)[/]","blazorwasm");
    projectOptions.Add("Blazor web server [yellow](blazorserver)[/]","blazorserver");

    string[] choices = projectOptions.Keys.ToArray();
 
    GenericUi.showTitle("Project Initializer");

    project.type = projectOptions[Menus.show(choices)];
    project.name = GenericUi.ask("Project name");

    await ProjectGem.newProject(project);
  }


  //public static Task effiencyMode(){}
  
  public async static Task easyMode(){}


}
