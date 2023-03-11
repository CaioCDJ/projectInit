using projectInit;
using projectInit.Data;



Database db = await Database.constructor();


foreach(Package package in db.Packages){
  Console.WriteLine($"\nnome:{package.name}\ndesc:{package.desc}");
}

//await db.SaveChanges();
/*

if(args.Length<=0)
  await FriendlyMode.handle();
else
  await EfficiencyMode.handle(args);

*/
