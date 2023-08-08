int resp;
do{
    GerarMenu();
    Console.WriteLine("\nIr para onde?");
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

void GerarMenu() {
    Console.WriteLine("-=X Menu Inicial X=-");
    Console.WriteLine("1 - Calcular área");
    Console.WriteLine("2 - Conversão de moeda");
    Console.WriteLine("3 - Comparar números");
    Console.WriteLine("4 - Verificar faixa etária");
    Console.WriteLine("5 - Fibonacci");
    Console.WriteLine("6 - 1000 Números");
    Console.WriteLine("7 - Sair");
}


void Ex01(){
    Console.WriteLine("-=X Calcular Área X=-");
    string sair;
    do{
        Console.WriteLine("\nInforme a Largura:");
        int largura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a Altura:");
        int altura = Convert.ToInt32(Console.ReadLine());
        int area = largura * altura;
        Console.WriteLine("A área é: " + area);
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex02(){
    Console.WriteLine("-=X Conversão de Moeda X=-");
    string sair;
    do{
        Console.WriteLine("\nInforme o valor para ser convertido (em R$)");
        double real = Convert.ToInt32(Console.ReadLine());
        double dolar = real / 5.18;
        double euro = real / 5.31;
        double peso = real / 0.04;
        Console.WriteLine(real + " reais são equivalentes a:");
        Console.WriteLine(dolar + " dólares");
        Console.WriteLine(euro + " euros");
        Console.WriteLine(peso + " pesos argentinos");
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex03(){
    Console.WriteLine("-=X Comparar Números X=-");
}

void Ex04(){
    Console.WriteLine("-=X Verificar Faixa Etária X=-");
}

void Ex05(){
    Console.WriteLine("-=X Fibonacci X=-");
}

void Ex06(){
    Console.WriteLine("-=X 1000 Números X=-");
}