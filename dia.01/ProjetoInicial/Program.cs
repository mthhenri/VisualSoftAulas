int resp = 0;
do{
    Console.WriteLine("Ir para onde?");
    resp = Convert.ToInt32(Console.ReadLine());
    switch(resp){
    case 1:
        Ex01();
        break;
    case 2:
        Ex02();
        break;
    case 3:
        Ex03();
        break;
    case 4:
        Ex04();
        break;
    case 5:
        Ex05();
        break;
    case 6:
        Ex06();
        break;
    default:
        break;
    }
}while(resp != 7);

static void Ex01(){
    string sair = "";
    do{
        int largura;
        Console.WriteLine("Informe a Largura:");
        largura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a Altura:");
        int altura = Convert.ToInt32(Console.ReadLine());
        int area = largura * altura;
        Console.WriteLine("A área é: " + area);
        Console.WriteLine()
        Console.WriteLine("Deseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("S") || sair.Equals("s"));
}

void Ex02(){
    string sair = "";
    do{
        Console.WriteLine("Informe o valor para ser concertido (em R$)");
        int real = Convert.ToInt32(Console.ReadLine());
        int dolar = real / 5.18;
        int euro = real / 5.31;
        int peso = real / 0.04;
        Console.WriteLine(real + " reais são equivalentes a:")
        Console.WriteLine(dolar + " dólares")
        Console.WriteLine(euro + " euros")
        Console.WriteLine(peso + " pesos argentinos")
        Console.WriteLine()
        Console.WriteLine("Deseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("S") || sair.Equals("s"))
}

void Ex03(){
    
}

void Ex04(){
    
}

void Ex05(){
    
}

void Ex06(){
    
}