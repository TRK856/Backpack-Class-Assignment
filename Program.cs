#nullable disable

Backpack sBackpack = new Backpack("Blue", "Small");
Backpack mBackpack = new Backpack("Red", "Medium");
Backpack lBackpack = new Backpack("Green", "Large");

sBackpack.OpenBag();
sBackpack.PutIn("lunch");
sBackpack.PutIn("jacket");
sBackpack.CloseBag();

sBackpack.OpenBag();
sBackpack.TakeOut("jacket");
sBackpack.CloseBag();
