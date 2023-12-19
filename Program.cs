// See https://aka.ms/new-console-template for more information


using celular_desafio_dio.Models;
Console.WriteLine("*** Iphone ***");
Smartphone iphone = new Iphone(numero: "123456", modelo: "0236A", imei: "122", memoria: 265);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(" DioInnovation");

Console.WriteLine("------------------------------------------");

Console.WriteLine("*** Nokia ***");
Smartphone nokia = new Nokia(numero: "1256", modelo: "ABC", imei: "333", memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo(" Github");

