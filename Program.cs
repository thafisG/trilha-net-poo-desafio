using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia N1 = new Nokia(numero: "(11)2345-6789", modelo: "Nokia ModeloX", imei: "IMEI123", memoria: 64);
N1.ReceberLigacao();
N1.InstalarAplicativo("AppNokia");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone P1 = new Iphone(numero: "(11)5845-6888", modelo: "Iphone 15 Pro", imei: "IMEI555", memoria: 128);
P1.ReceberLigacao();
P1.InstalarAplicativo("AppIphone");