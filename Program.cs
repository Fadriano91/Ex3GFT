var sucoL = 5;
var sucoT = 5;

Console.WriteLine("Escola o Suco: ");
Console.WriteLine("L - Limão ");
Console.WriteLine("T - Tamarindo");
var opcaoSuco = (Console.ReadLine());

if( opcaoSuco == "L"){ 
    Console.WriteLine("Quantidade de suco de limao");
    var qntL = Int32.Parse(Console.ReadLine());
}else if(opcaoSuco =="T"){
    Console.WriteLine("Quantidade de suco de tamarindo");
    var qntT = Int32.Parse(Console.ReadLine());
}

//não consegui finalizar, tive um pouco de dificuldade pra iniciar