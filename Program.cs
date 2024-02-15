//2ci tapsirig
Console.WriteLine("4 reqemli eded daxil edin");
int eded=Convert.ToInt32(Console.ReadLine());
int eded1 = eded / 1000;
int eded2 = (eded - (eded1 * 1000)) / 100;
int eded3 = (eded - (eded1 * 1000) - (eded2 * 100)) / 10;
int eded4 = (eded - (eded1 * 1000) - (eded2 * 100) - (eded3 * 10));


Console.WriteLine("birinci ve ucuncu reqemlerin cemi  " + (eded1 + eded3));
Console.WriteLine("ikinci ve dorduncunun ferqi " + (eded2 - eded4));