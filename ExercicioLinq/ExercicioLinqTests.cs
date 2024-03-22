namespace ExercicioLinq
{
    public class ExercicioLinqTests
    {
        private List<Produto> produtos;

        public ExercicioLinqTests()
        {
            produtos = new List<Produto>();
            produtos.Add(new Produto { Nome = "Sabão", Valor = 1.1m, Quantidade = 10 });
            produtos.Add(new Produto { Nome = "Detergente de prato", Valor = 10, Quantidade = 9 });
            produtos.Add(new Produto { Nome = "Água", Valor = (decimal)8.2f, Quantidade = 8 });
            produtos.Add(new Produto { Nome = "Esponja", Valor = (decimal)5.5, Quantidade = 7 });
            produtos.Add(new Produto { Nome = "Água sanitária", Valor = (decimal)30.30d, Quantidade = 6 });
            produtos.Add(new Produto { Nome = "Vassoura", Valor = 3.3m, Quantidade = 5 });
            produtos.Add(new Produto { Nome = "Desinfetante", Valor = 4.4m, Quantidade = 4 });
            produtos.Add(new Produto { Nome = "Pano de chão", Valor = 5.5m, Quantidade = 3 });
            produtos.Add(new Produto { Nome = "Purificador de água", Valor = 6.6m, Quantidade = 2 });
            produtos.Add(new Produto { Nome = "Balde", Valor = 10.1m, Quantidade = 1 });
        }

        [Fact(DisplayName = "Quantidade de produtos que possuem a palavra 'água' no nome.")]
        public void Test1()
        {
            var qntAgua = produtos
                .Where(x => x.Nome == "água")
                .ToList();
            foreach (var item in qntAgua)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Produtos ordenados por nome.")]
        public void Test2()
        {
            var orderAZ = produtos
                .OrderBy(x => x.Nome)
                .ToList();
            foreach (var item in orderAZ)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Produtos ordenados do mais caro para o mais barato.")]
        public void Test3()
        {
            var highLow = produtos
                .OrderBy(x => x.Valor)
                .ToList();
            foreach (var item in highLow)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Produto mais caro")]
        public void Test4()
        {
            var higherPrice = produtos
                .OrderBy(x => x.Valor)
                .ToList();
            foreach (var item in higherPrice)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Produto mais barato")]
        public void Test5()
        {
            var lowerPrice = produtos
                .OrderByDescending(x => x.Valor)
                .ToList();
            foreach (var item in lowerPrice)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Lista dos nomes dos produtoss")]
        public void Test6()
        {
            var listName = produtos
                .OrderBy(x => x.Nome)
                .ToList();
            foreach (var item in listName)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Quantidade total de todos dos produtos")]
        public void Test7()
        {
            var qntTotal = produtos
                .OrderBy(x => x.Quantidade)
                .ToList();
            foreach (var item in qntTotal)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Nome dos produtos com valor até 10.0")]
        public void Test8()
        {
            var prodValue = produtos
                .Where(x => x.Valor == 10)
                .ToList();
            foreach (var item in prodValue)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Nome dos produtos com valor maior 10.0")]
        public void Test9()
        {
            var higherThan = produtos
                .Where(x => x.Valor > 10)
                .ToList();
            foreach (var item in higherThan)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Fact(DisplayName = "Verifica se o produto 'pão' está na lista")]
        public void Test10()
        {
            var Bread = produtos
                .OrderBy(x => x.Nome)
                .ToList();
            foreach (var item in Bread)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}