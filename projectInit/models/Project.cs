
namespace projectInit;

public class Project{
  
  public string? name { get; set; } = "project";
  public string? type { get; set; } = "console";
  public bool tests { get; set; }  = false;
  public int? version { get; set; }  = 6;
  public string[]? packages { get; set; }
  public string? archetecture{ get; set; }

}
