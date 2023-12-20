# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
- Fazendo a herança da classe Smartphone para a classe Nokia
- Iniciando o construtor da classe Nokia
- Herdando o método "InstalarAplicativo()" da classe Smartphone e sobrescrevendo
``` 
namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalação do Aplicativo: {nomeApp} conluída");
        }
    }
}
 ```
### Testando os métodos de ambas as classes
```
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

```
