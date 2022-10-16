using DesafioPOO.Models;

Console.WriteLine("Testando Smartphone Nokia");
Nokia TelNokia = new Nokia(numero: "12345678", modelo: "Nokia123", imei: "12345", memoria: 68);
TelNokia.ReceberLigacao();
TelNokia.InstalarAplicativo("Valorant");

Console.WriteLine("\n-----------------------------------\n");

Console.WriteLine("Testando Iphone");
Iphone TelIphone = new Iphone(numero: "87654321", modelo: "Iphone123", imei: "54321", memoria: 34);
TelIphone.Ligar();
TelIphone.InstalarAplicativo("COD");