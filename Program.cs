using System;
using System.Collections.Generic;
using POO_lista_de_objetos.classes;


namespace POO_lista_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
           //criamos a lista
            List<Produto> produto = new List<Produto>();

            // Adicinamos produtos através  de instância com métodos construtores
            produto.Add(new Produto(1, "Ovo", 0.5f));
            produto.Add(new Produto(2, "Fermento", 4.5f));
            produto.Add(new Produto(3, "Sal", 2.5f));
            produto.Add(new Produto(4, "Açúcar", 3.5f));
            produto.Add(new Produto(5, "Oleo", 9f));
            produto.Add(new Produto(7, "Agua", 0f));
           
           // Método intanciado com atributos
           Produto farinha = new Produto();
           farinha.Codigo = 6;
           farinha.Nome = "Farinha";
           farinha.Preco = 10f;

           produto.Add(farinha);

           //Mostrar produtos com foreach
           foreach (Produto p in produto)
           {
               Console.WriteLine($" Código: {p.Codigo} Nome: {p.Nome} Preço - R$ {p.Preco}");
           }
            //´Podemos remove item atraves do seu índice de arrey
            //Linha removida na posição 3 : Produto( 4 , "Açucar", 3.5f)
            
            // (produto.RemoveAt(3);)


            // Tambem podemsos remover um produto da lista com a expressão lambida e o método (RemoveAll)
            //Linha removida : Produto(8, "Agua", 0f)
            produto.RemoveAll(produto => produto.Nome == "Agua");

            Console.WriteLine("\nlista alterada "); 
            
            foreach (Produto p in produto)
            {
                Console.WriteLine($"{p.Codigo} {p.Nome} , R$ {p.Preco}");
            }
        }
    }
}
