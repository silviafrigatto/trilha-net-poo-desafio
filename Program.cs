using DesafioPOO.Models;

Console.WriteLine("Testando Iphone");
Smartphone iphone = new Iphone(numero: "12345678", modelo:"a", imei: "111111", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Testando Nokia");
Smartphone nokia = new Iphone(numero: "12345678", modelo:"a", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
