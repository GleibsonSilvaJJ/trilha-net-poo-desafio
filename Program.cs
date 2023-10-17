using System.ComponentModel;
using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "11111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram ");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "88559655", modelo: "Modelo 2", imei: "222222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram ");