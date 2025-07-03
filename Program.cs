using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone 

Console.WriteLine("Bem vindo ao sistema de Teste de Smartphones!\n");

Console.Clear();
Console.WriteLine("Smartphone Nokia Lumia\n");
Smartphone nokia = new Nokia("11999999999", "Lumia 920", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("MSN Messenger");

Console.WriteLine("\nSmartphone iPhone\n");
Smartphone iphone = new Iphone("11988888888", "iPhone 12", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");