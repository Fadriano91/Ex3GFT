var sucoL = 10;
var sucoT = 10;

Console.WriteLine("Escola o Suco: ");
Console.WriteLine("L - Limão ");
Console.WriteLine("T - Tamarindo");
var opcaoSuco = (Console.ReadLine());

if( opcaoSuco == "L"){ 
    Console.WriteLine("Quantidade de suco de limao");
    var qntL = Int32.Parse(Console.ReadLine());
    if(qntL <= 2){
        var totalL = (qntL * sucoL)* 0.97;
        Console.WriteLine("Você teve desconto de 3% por litro!");
        Console.WriteLine("Total a Pagar:" + totalL);
    }else if(qntL >2 && qntL <= 5){
        var totalL = (qntL * sucoL)* 0.96;
        Console.WriteLine("Você teve desconto de 4% por litro!");
        Console.WriteLine("Total a Pagar:" + totalL);
    }else{
        var totalL = (qntL * sucoL)* 0.95;
        Console.WriteLine("Você teve desconto de 5% por litro!");
        Console.WriteLine("Total a Pagar:" + totalL);
    }
}else if(opcaoSuco =="T"){
    Console.WriteLine("Quantidade de suco de tamarindo");
    var qntT = Int32.Parse(Console.ReadLine());
    if(qntT <= 2){
        var totalT = (qntT * sucoT)* 0.96;
        Console.WriteLine("Você teve desconto de 4% por litro!");
        Console.WriteLine("Total a Pagar:" + totalT);
    }else if(qntT >2 && qntT <= 5){
        var totalT = (qntT * sucoT)* 0.95;
        Console.WriteLine("Você teve desconto de 5% por litro!");
        Console.WriteLine("Total a Pagar:" + totalT);
    }else{
        var totalT = (qntT * sucoT)* 0.94;
        Console.WriteLine("Você teve desconto de 6% por litro!");
        Console.WriteLine("Total a Pagar:" + totalT);
    }
}