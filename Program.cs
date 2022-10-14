using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("99854-6588", "Nokia", "1123.651.1155", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine($"\n");


Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("99856-6587", "Iphone", "4656.258.657", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");