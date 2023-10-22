using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
 Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.DatelhesSmartphone();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
 Smartphone iphone = new Iphone(numero: "4987", modelo: "iPhone Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.DatelhesSmartphone();
