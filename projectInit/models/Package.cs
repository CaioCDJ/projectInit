namespace projectInit;

public class Package{
  public string id { get; set; } = Guid.NewGuid().ToString();
  public string name{ get; set; }
  public string? desc{ get; set; }

  public Package(string name, string desc){
    this.desc = desc;
    this.name = name;
  }
}
