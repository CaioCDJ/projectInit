using Newtonsoft.Json;

namespace projectInit.Data;

public class Database{

  private static string path = Environment.CurrentDirectory;

  public List<Package> Packages = null;

  public static async Task<Database> constructor(){

    if(!VerifyDB()){
      Thread.Sleep(2000);
      await Migration.run(path);

    }
    string json = File.ReadAllText(path+"/db.json");
    
    Database database = new Database();
    database.Packages = JsonConvert.DeserializeObject<List<Package>>(json);

    return database;

  }

  private static bool VerifyDB()
   => File.Exists(path+"/db.json");
 
  //public static List<Package> SaveChanges(){}

  public async Task SaveChanges(){
    if(VerifyDB()){
      File.Delete(path+"db.json"); 
    
      File.Create(path+"db.json");

      string json = JsonConvert.SerializeObject(Packages);

      await File.WriteAllTextAsync(path+"/db.json", json);
    }
  }
}
