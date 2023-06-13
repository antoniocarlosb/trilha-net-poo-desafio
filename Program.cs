using DesafioPOO.Models;

Console.WriteLine("Smartphopne Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 2545", imei: "99999999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Watsapp");


Console.WriteLine("\n");

Console.WriteLine("Smartphopne IPhone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 2545", imei: "99999999999", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

