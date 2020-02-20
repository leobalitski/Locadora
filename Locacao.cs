using System;
using LeoFilme;
using LeoCliente;
using System.Collections.Generic;
using System.Globalization;


namespace LeoLocacao
{


    public class Locacao
    {
        // Atributos
        public int idLoc = 0;
        public Cliente cliente;
        public String dataLoc;
        public String dataDevolucao;
        public Double valorTotal;
        public int filmesLocados;

        // Lista de Filmes
        public List<Filme> filmes = new List<Filme>();

        // Construtor
        public Locacao(int idLoc, Cliente cliente)
        {

            this.idLoc = idLoc;
            this.cliente = cliente;

            this.cliente.adicionarLocacao(this);
        }

        // Adição de Filmes
        public void AdicFilme(Filme filme)
        {
            this.filmes.Add(filme);
            //Contador Filme Locado

        }

        // Método com o Valor Total das Locações
        public double PrecoTotal()
        {
            double total = 0;
            foreach (Filme filme in filmes)
            {
                total += filme.valorLoc;
            }
            return total;
        }

        // Método com a Quantidade de Filmes Locados
        public int QtdeFilmesLoc()
        {
            return this.filmes.Count;
        }

        //Calculo Data de Devolução 
        public String calculoData()
        {
            DateTime dataAtual = DateTime.Now;
			return dataAtual.AddDays(cliente.diaDev).ToString("MM/dd/yyyy h:mm tt");
        }
    }
}//aa//dapsinpnisdapnisdapnisa