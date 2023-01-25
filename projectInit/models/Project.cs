
namespace projectInit;

public class Project{
  
  public string? name { get; set; }
  public string? type { get; set; }
  public bool tests { get; set; }  = false;
  public int? version { get; set; }  = 6;
  public string[]? packages { get; set; }
  public string? archetecture{ get; set; }

  public string GetGemString(){
   return $"dotnet new { this.type } -o { this.name }"; 
  }
}
