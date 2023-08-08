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
    Console.WriteLine("\n-=X Menu Inicial X=-");
    Console.WriteLine("1 - Calcular área");
    Console.WriteLine("2 - Conversão de moeda");
    Console.WriteLine("3 - Comparar números");
    Console.WriteLine("4 - Verificar faixa etária");
    Console.WriteLine("5 - Fibonacci");
    Console.WriteLine("6 - 1000 Números");
    Console.WriteLine("7 - Sair");
}


void Ex01(){
    Console.WriteLine("\n-=X Calcular Área X=-");
    string sair;
    do{
        Console.WriteLine("Informe a Largura:");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a Altura:");
        double altura = Convert.ToDouble(Console.ReadLine());
        double area = largura * altura;
        Console.WriteLine("A área é: " + Math.Round(area , 2));
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex02(){
    Console.WriteLine("\n-=X Conversão de Moeda X=-");
    string sair;
    do{
        Console.WriteLine("Informe o valor para ser convertido (em R$)");
        double real = Convert.ToDouble(Console.ReadLine());
        double dolar = real / 5.18;
        double euro = real / 5.31;
        double peso = real / 0.04;
        Console.WriteLine("\n" + real + " reais são equivalentes a:");
        Console.WriteLine(Math.Round(dolar, 2) + " dólares");
        Console.WriteLine(Math.Round(euro, 2) + " euros");
        Console.WriteLine(Math.Round(peso, 2) + " pesos argentinos");
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex03(){
    Console.WriteLine("\n-=X Comparar Números X=-");
    string sair;
    do{
        Console.WriteLine("Informe o primeiro número");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo número");
        double n2 = Convert.ToDouble(Console.ReadLine());
        if(n1 < n2){
            Console.WriteLine("\n" + n1 + " é menor do que " + n2);
        } else if (n1 > n2){
            Console.WriteLine("\n" + n1 + " é maior do que " + n2);
        } else {
            Console.WriteLine("\nOs números são iguais");
        }
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex04(){
    Console.WriteLine("\n-=X Verificar Faixa Etária X=-");
    string sair;
    do{
        Console.WriteLine("Informe a idade");
        int idade = Convert.ToInt32(Console.ReadLine());
        if(idade <= 13){
            Console.WriteLine("\n" + idade + " anos é criança");
        } else if (idade <= 18){
            Console.WriteLine("\n" + idade + " anos é adolecente");
        } else if (idade <= 60){
            Console.WriteLine("\n" + idade + " anos é adulto");
        } else {
            Console.WriteLine("\n" + idade + " anos é idoso");
        }
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex05(){
    Console.WriteLine("\n-=X Fibonacci X=-");
    string sair;
    do{
        Console.WriteLine("Insira um número");
        int limite = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int fiboA = 0;
        int fiboB = 1;
        int fiboC;
        if(limite <= fiboB){
            if(limite == fiboA){
                Console.WriteLine(fiboA);
            } else {
                Console.WriteLine(fiboA);
                Console.WriteLine(fiboB);
            }
        } else {
            do{
                if(fiboA < limite){
                    Console.WriteLine(fiboA);
                    fiboC = fiboA + fiboB;
                    if(fiboB < limite){
                        Console.WriteLine(fiboB);
                        fiboA = fiboC + fiboB;
                        if(fiboC < limite){
                            Console.WriteLine(fiboC);
                            fiboB = fiboA + fiboC;
                        }
                    }
                }
            }while(fiboA < limite);
        }
        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}

void Ex06(){
    Console.WriteLine("\n-=X 1000 Números X=-");
    string sair;
    do{

        Console.WriteLine("\nDeseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("N", StringComparison.OrdinalIgnoreCase));
}