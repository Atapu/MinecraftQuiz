using System;

class Quiz
{
    public static void Main()
    //START
    {
        //Intro
        int correct = 0; //correct
        int wrong = 0; //wrong
        int grade = 0; //grade
        Console.WriteLine("MINECRAFT (Nether Update) QUIZ \nResponda às perguntas corretamente: \n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
        Console.ReadKey();
        Console.Clear();

        //Question 1
            Console.WriteLine("1) Qual a quantidade mínima de blocos de obsidiana necessários para contruir um portal para o Nether?\na) 6\nb) 8\nc) 10\nd) 12\ne) 14");
            if (Console.ReadLine() == "c") //answer
            {
                Console.WriteLine("Correto\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                correct = correct + 1; //add to correct nb
                grade = grade + 20;
            }
            else
            {
                Console.WriteLine("Errado\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                wrong = wrong + 1; //add to wrong nb
            }
        

        //Question 2
            Console.WriteLine("2) Existe um mob habitante do Nether que se torna passivo quando o jogador utiliza um certo tipo de armadura, que mob é esse? \na) Creeper \nb) Zumbi \nc) Piglin-zumbi \nd) Piglin \ne) Porco");
            if (Console.ReadLine() == "d") //answer
            {
                Console.WriteLine("Correto\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                correct = correct + 1; //add to correct nb
                grade = grade + 20;
            }
            else
            {
                Console.WriteLine("Errado\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                wrong = wrong + 1; //add to wrong nb
            }

        //Question 3
            Console.WriteLine("3) Qual é o material do qual a armadura que torna o Piglin passivo é feita? \na) Couro \nb) Ouro \nc) Malha \nc) Ferro \nd) Diamante ");
            if (Console.ReadLine() == "b") //answer
            {
                Console.WriteLine("Correto\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                correct = correct + 1; //add to correct nb
                grade = grade + 20;
            }
            else
            {
                Console.WriteLine("Errado\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                wrong = wrong + 1; //add to wrong nb
            }

        //Question 4
            Console.WriteLine("Qual item não é encontrado naturalmente no Nether? \na) Bola de neve \nb) Bastão de Blaze \nc) Lágrima de Ghast \nd) Fungo do Nether \ne) Pólvora");
            if (Console.ReadLine() == "a") //answer
            {
                Console.WriteLine("Correto\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                correct = correct + 1; //add to correct nb
                grade = grade + 20;
            }
            else
            {
                Console.WriteLine("Errado\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                wrong = wrong + 1; //add to wrong nb
            }

        //Question 5
            Console.WriteLine("5) Quais itens são necessários para formar um Wither? \na) Uma abóbora e dois blocos de neve \nb) Uma abóbora e quatro blocos de ferro \nc) Duas abóboras e dois blocos de ferro \nd) Uma cabeça de Wither e quatro blocos de areia da alma \ne) Três cabeças de Wither e quatro blocos de areia da alma");
            if (Console.ReadLine() == "e") //answer
            {
                Console.WriteLine("Correto\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                correct = correct + 1; //add to correct nb
                grade = grade + 20;
            }
            else
            {
                Console.WriteLine("Errado\n<PRESSIONE QUALQUER TECLA PARA CONTINUAR>");
                Console.ReadKey();
                Console.Clear();
                wrong = wrong + 1; //add to wrong nb
            }
            
        Console.WriteLine("Corretas: " + correct + "\nErradas: " + wrong);
        Console.WriteLine("\nNota: " + grade + "%");
        Console.ReadKey();
        Console.Clear();
        //END
    }

}