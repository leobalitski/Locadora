﻿using System;
using LeoLocacao;
using LeoFilme;
using LeoCliente;




namespace ProvaLocadora
{



    public class Principal
    {

        static void Main(String[] args)
        {


            Console.WriteLine("Leonardinho\n   ");

            // Lista com 5 Clientes
            Cliente cliente1 = new Cliente(1, "Leonardo Filipini", "18/08/1997", "123.123.123-12", 3);
            Cliente cliente2 = new Cliente(2, "matheus barbie", "13/08/1945", "456.456.456-45", 2);
            Cliente cliente3 = new Cliente(3, "kadu kururu", "02/12/2001", "789.789.789-78", 3);
            Cliente cliente4 = new Cliente(4, "nelsinha", "11/02/1988", "098.098.098-09", 2);
            Cliente cliente5 = new Cliente(5, "mariazinha", "15/07/1995", "753.753.753-75", 3);

            // Lista com 10 Filmes
            Filme filme1 = new Filme(1, "Ben Hur", "25/01/1958",
                    "Ben-Hur é um mercador judeu que, após um desentendimento, é condenado a viver como escravo por um amigo de juventude,\n   Messala, que é o chefe das legiões romanas da cidade. Mas uma surpreendente oportunidade de vingança surge de onde ele menos espera.",
                    4.5, 5);
            Filme filme2 = new Filme(2, "Encontro Marcado", "08/10/1998",
                    "Quando o Anjo da Morte chega à Terra para buscar um magnata da mídia, suas experiências como mortal o levam a se apaixonar\n   pela filha do milionário. A Morte então decide fazer um acordo com o empresário para que ambos possam permanecer mais tempo na Terra.",
                    3.5, 3);
            Filme filme3 = new Filme(3, "Crash", "01/05/2004",
                    "Tensões raciais emergem em uma série de histórias envolvendo moradores de Los Angeles. Diversos personagens das mais\n   variadas origens étnicas se cruzam em um incidente. Os diferentes estereótipos que a sociedade criou para esses grupos raciais afeta seu\n   julgamento, crenças e atitudes, o que causa problemas e tensões para todos.",
                    2.5, 2);
            Filme filme4 = new Filme(4, "Endiabrado", "20/11/2004",
                    "Desesperado para ganhar a afeição de uma bela colega de trabalho, Elliot faz um acordo com o Diabo, uma mulher maravilhosa,\n   com um perverso senso de humor. Em troca da alma de Elliot, ela vai lhe conceder sete desejos, mas a cada desejo, ele recebe mais\n   do que pede.",
                    2.5, 1);
            Filme filme5 = new Filme(5, "Tomates Verdes Fritos", "05/03/2001",
                    "Evelyn Couch (Kathy Bates) visita com o marido um parente no asilo de idosos. Uma vez lá, ela encontra Ninny Threadgoode\n   (Jessica Tandy), uma mulher idosa, que a ilumina e traz uma nova perspectiva através de contos do seu passado. Evelyn ganha a confiança\n   necessária para mudar sua própria vida para melhor.",
                    3.5, 2);
            Filme filme6 = new Filme(6, "Robocop", "18/09/1997",
                    "Policial é morto em combate e transformado por cientistas da empresa que dirige a força policial em um ciborgue\n   ultrassofisticado a fim de ser usado na luta contra o crime na cidade de Detroit. Porém, apesar de ter sua memória apagada,\n   lembranças o assombram e o levam a buscar vingança.",
                    2.5, 2);
            Filme filme7 = new Filme(7, "Harry Potte e o Prisioneiro de Azkaban", "07/08/2004",
                    "O terceiro ano de Harry Potter em Hogwarts começa mal quando ele descobre que o assassino Sirius Black escapou da prisão\n   de Azkaban e está empenhado em matá-lo. Enquanto o gato de Hermione atormenta o rato doente de Ron, um bando de dementadores são enviados\n   para proteger a escola de Sirius Black. Um professor misterioso ajuda Harry a aprender a se defender.",
                    3.5, 3);
            Filme filme8 = new Filme(8, "Psicose", "15/10/1960",
                    "Após roubar 40 mil dólares para se casar com o namorado, uma mulher foge durante uma tempestade e decide passar a noite em\n   um hotel que encontra pelo caminho. Ela conhece o educado e nervoso proprietário do estabelecimento, Norman Bates, um jovem com um\n   interesse em taxidermia e com uma relação conturbada com sua mãe. O que parece ser uma simples estadia no local se torna uma verdadeira noite de terror.",
                    3.5, 1);
            Filme filme9 = new Filme(9, "leo jones", "07/05/1993",
                    "Leo jones teve uma infancia dificil, dai virou dev e ficou tudo top\n   quando vira dev fica chave.",
                    2.5, 3);
            Filme filme10 = new Filme(10, "Vingadores Ultimato", "16/07/2019",
                    "Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a perda de amigos e entes queridos.\n   Com Tony Stark vagando perdido no espaço sem água e comida, Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco.",
                    4.5, 8);

            // IdCliente / Menu
            int idCliente = 0;
            Locacao locacao;
            do
            {
                Console.WriteLine("\nInforme o ID : ");
                String entrada = Console.ReadLine();
                idCliente = Convert.ToInt32(entrada);
                switch (idCliente)
                {
                    case 1:
                        /* OUTRA MANEIRA DE ADD LOCAÇÃO - FILMES
                        cliente1.locacoes.add(new Locacao(01, cliente1));
                        cliente1.locacoes.get(0).AdicFilme(filme1);
                        */
                        cliente1.mostrarCliente(); // Impressão CLIENTE "1"
                        locacao = new Locacao(01, cliente1); // Nova locações
                        locacao.AdicFilme(filme1); // Adicionando Filme
                        locacao.AdicFilme(filme6); //        "
                        locacao.AdicFilme(filme10);//        "
                        filme1.mostrarFilme(); // Impressão dos Filmes
                        filme6.mostrarFilme(); //         "
                        filme10.mostrarFilme();//         "
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 2:
                        cliente2.mostrarCliente();
                        locacao = new Locacao(02, cliente2);
                        locacao.AdicFilme(filme2);
                        locacao.AdicFilme(filme7);
                        filme2.mostrarFilme();
                        filme7.mostrarFilme();
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 3:
                        cliente3.mostrarCliente();
                        locacao = new Locacao(03, cliente3);
                        locacao.AdicFilme(filme3);
                        locacao.AdicFilme(filme6);
                        locacao.AdicFilme(filme7);
                        locacao.AdicFilme(filme8);
                        filme3.mostrarFilme();
                        filme6.mostrarFilme();
                        filme7.mostrarFilme();
                        filme8.mostrarFilme();
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());

                        break;
                    case 4:
                        cliente4.mostrarCliente();
                        locacao = new Locacao(04, cliente1);
                        locacao.AdicFilme(filme4);
                        locacao.AdicFilme(filme9);
                        filme4.mostrarFilme();
                        filme9.mostrarFilme();
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 5:
                        cliente5.mostrarCliente();
                        locacao = new Locacao(05, cliente1);
                        locacao.AdicFilme(filme1);
                        locacao.AdicFilme(filme5);
                        locacao.AdicFilme(filme10);
                        filme1.mostrarFilme();
                        filme5.mostrarFilme();
                        filme10.mostrarFilme();
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                }
            } while (idCliente <= 5);

        }
    }
}