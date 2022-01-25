namespace Salario_Liquido {
    class Program{
        public static void Main (string[] args){

            /*Construa um programa que leia as informações de: horas trabalhadas (HT), 
            valor da hora trabalhada (VH). Calcule e apresente o salário líquido dos 
            empregados da empresa, baseado nas tabelas abaixo.
            OBS: Salário Líquido = Salário Bruto – INSS – Imposto de Renda
            a) INSS = 11% do salário bruto
            b) Imposto de Renda  após descontar o INSS usar esse valor e ler a 
            alíquota do imposto de renda na tabela abaixo

                Salário Bruto – INSS  |  Alíquota  |  Deduzir
                      Até $900        |   Isento   |
                  De $900 até $1800   |    15%     |   $135
                    Mais que $1800    |   27,5%    |   $360

            Não é conhecido o número de funcionários da empresa. Ao final de cada cálculo, 
            o programa deve perguntar se a pessoa deseja calcular o salário de outro funcionário. 
            Caso a resposta seja negativa, o programa deve parar.*/

            double ir, salb, salliq, psal, ht, vt, op;

            do{
                Console.Write("Entre com as horas trabalhadas: ");
                ht = double.Parse(Console.ReadLine());
                Console.Write("Entre com o valor da hora trabalhada: ");
                vt = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                salb = ht*vt;
                psal = salb - (salb*0.11);
                //Salário bruto menor que 900
                if (psal <= 900){
                    salliq = psal;
                    Console.WriteLine("O salário líquido desse funcionário é R${0:N}.", salliq);
                    Console.WriteLine("");
                }
                else
                    //Salário bruto de 900 até 1800
                    if (psal >= 900 && psal <= 1800){
                        ir = (0.15*psal)-135;
                        salliq = psal - ir;
                        Console.WriteLine("O salário líquido desse funcionário é R${0:N}.", salliq);
                        Console.WriteLine("");
                    }
                    else 
                        //Salário bruto maior que 1800
                        if (psal>1800){
                            ir = (0.275*psal)-360;
                            salliq = psal-ir;
                            Console.WriteLine("O salário líquido desse funcionário é R${0:N}.", salliq);
                            Console.WriteLine("");
                        }
                //Verificação de continuar no programa, calculando o salário líquido de outro funcionário        
                do {
                    Console.WriteLine("Você deseja calcular o salário líquido de outro funcionário?");
                    Console.WriteLine("S - para sim");
                    Console.WriteLine("N - para não");
                    Console.Write("Digite a sua opção: ");
                    op = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("");
                    if (op!='S' && op!='N'){
                        Console.WriteLine("Entre com uma opção válida!");
                    }
                } while (op!='S' && op!='N');
            } while (op=='S');
        }
    }
}
