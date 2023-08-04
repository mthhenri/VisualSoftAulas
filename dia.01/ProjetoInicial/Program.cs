int resp = 0;
do{
    Console.WriteLine("Ir para onde?");
    resp = Convert.ToInt32(Console.ReadLine());
    switch(resp){
    case 1:
        Ex01();
        break;
    case 2:
        break;
    case 3:
        break;
    case 4:
        break;
    case 5:
        break;
    case 6:
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
        Console.WriteLine("Deseja sair? [S/N]");
        sair = Console.ReadLine();
    }while(sair.Equals("S") || sair.Equals("s"));
}

void Ex02(){
    
}

void Ex03(){
    
}

void Ex04(){
    
}

void Ex05(){
    
}

void Ex06(){
    
}