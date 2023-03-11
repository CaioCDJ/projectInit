using Newtonsoft.Json;

namespace projectInit.Data;

public class Migration{

  public static async Task run(string path){

    // some common nuget packages
    List<Package>packages = new List<Package> {
      new Package("Newtonsoft.Json",""),
      new Package("Dapper",""),
      new Package("Microsoft.EntityFrameworkCore.Design",""),
      new Package("Microsoft.EntityFrameworkCore.SqlServer",""),
      new Package("Microsoft.EntityFrameworkCore.Tools",""),
      new Package("Microsoft.EntityFrameworkCore.InMemory",""),
      new Package("Npgsql.EntityFrameworkCore.PostgreSQL",""),
      new Package("Mediatr",""),
      new Package("FluentValidation.AspNetCore",""),
      new Package("Swashbuckle.AspNetCore.Swagger",""),
      new Package("Polly",""),
      new Package("Serilog",""),
      new Package("Spectre.Console",""),
    };

    string json = JsonConvert.SerializeObject(packages);

    File.Create(path+"db.json");

    await File.WriteAllTextAsync(path+"/db.json", json);
  }
}
