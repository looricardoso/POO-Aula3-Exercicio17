// Exercicio 17
// Entrar via teclado com o valor de cinco produtos. Após as entradas,
// digitar um valor referente ao pagamento da somatória destes valores.
// Calcular e exibir o troco que deverá ser devolvido.

Console.Clear();

string[] produto = new string[5];
double[] valor = new double[5];
double total=0, valorPago=0, troco=0;

for (int i=0; i<5; i++){

    Console.WriteLine("Digite a descrição do {0}º produto e em seguida seu valor:", i+1);
    Console.Write("Digite a descrição: ");
    produto[i] = Console.ReadLine();
    Console.Write("Digite o valor: ");
    valor[i] = double.Parse(Console.ReadLine());
    Console.Clear();

};

foreach (double somaValorProdutos in valor)
{
    total+= somaValorProdutos;
}



do {
    Console.WriteLine("O valor total da compra é: R$ {0}", Math.Round(total,2));
    Console.Write("Digite o valor pago: ");
    valorPago = double.Parse(Console.ReadLine());

    troco = (valorPago-total);

    if (troco < 0) {
        Console.WriteLine("\nValores incorretos, favor conferir.");
        Console.Write("Aperte qualquer tecla para repetir a operação.");
        Console.ReadKey();
        Console.Clear();    
    };

    Console.Clear();
} while (troco < 0);

Console.WriteLine("-- Resumo --\n");
Console.WriteLine("Total da compra: R$ {0}", Math.Round(total,2));
Console.WriteLine("Valor pago pelo cliente: R$ {0}", Math.Round(valorPago,2));
Console.WriteLine("Troco: R$ {0}\n", Math.Round(troco,2));

int emitirCupom=0;
Console.WriteLine("Deseja visualizar o cupom fiscal na tela?");
Console.WriteLine("Tecle (1) para Sim e (2) para Não");

emitirCupom = int.Parse(Console.ReadLine());

if (emitirCupom == 1) {
    Console.Clear();
    Console.WriteLine("x----------------------------------------x");
    Console.WriteLine("|              CUPOM FISCAL              |");
    Console.WriteLine("x---x--------------------------x---------x");
    Console.WriteLine("|Seq|        Descrição         |  Valor  |");
    Console.WriteLine("x---x--------------------------x---------x");

    for (int i = 0; i < 5; i++)
    {
        Console.Write("| {0} | ", i+1);
        Console.Write("{0,-25}", produto[i]);
        Console.Write("|");
        Console.Write("{0,8}", valor[i]);
        Console.WriteLine(" |");
    };

    Console.WriteLine("x---x--------------------------x---------x");

    Console.WriteLine("\nAperte qualquer tecla para finalizar.");
    Console.ReadKey();
    Console.Clear();
} else if (emitirCupom == 2) {
    Console.Clear();
    Console.WriteLine("Fim do programa.");
    Console.WriteLine("Aperte qualquer tecla para finalizar.");
    Console.ReadKey();
    Console.Clear();
} else {
    Console.WriteLine("Opção inválida.");
    Console.WriteLine("Aperte qualquer tecla para finalizar.");
    Console.ReadKey();
    Console.Clear();
};

// Console.WriteLine("Troco: R$ {0}", troco);

Console.ReadKey();
Console.Clear();
