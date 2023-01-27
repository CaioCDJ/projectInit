using projectInit;

public class Program{

  public async static Task Main(string[] args) {
    
    if(args.Length<=0)
      await FriendlyMode.handle();
    else
      await EfficiencyMode.handle(args);
  }

}
