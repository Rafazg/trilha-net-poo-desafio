using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone myIphone = new Iphone("123456789", "iPhone X", "123456789012345", 64);

myIphone.Ligar();
myIphone.ReceberLigacao();
myIphone.InstalarAplicativo("WhatsApp");

Smartphone nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");