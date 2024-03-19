// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Abstract classlar içinde hem metod imzası hem de metod tanımı bulundurabilir.

//Interfacelerde sadece metod imzası bulunmalıdır. .Net 8 ile gelen değişikliklerle beraber interfacelerde de artık metod tanımı bulunabiliyor.
//Bu durum tavsiye edilmez. Legacy projelere kolaylık sağlansın diye gelmiş bir özellik.


//Abstract class lar abstract keywordunu kullanır.
//Interface ler interface keywordunu kullanır.

//Abstract classlar çoklu kalıtımı desteklemez.
//Interfaceler ile çoklu kalıtım sağlayabiliriz. Bir class birden fazla interface'e sahip olabilir.

//Abstract classlar  constructor bulundurabilir.
//Interfacelerde constructor olmaz.

//Interface  bir objenin aynı isime sahip farklı işi yapan metodlarda kullanıma uygundur.
//Abstract classlar farklı objelerin aynı metodu aynı şekilde uygulandığı durumlarda kullanıma uygundur.

