using projectInit;

public class Program{

  public async static Task Main(string[] args) {
    
    if(args.Length>0)
      FriendlyMode.handle();
    else
      EfficiencyMode.handle(args);
  }

}
