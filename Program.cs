class PedidoCompra
{
      public int numero {get; set;}
      public string produto {get; set;}
      public int qtde {get; set;}
      public double preco {get; set;}
      public double desconto {get; set;}
      public double total {get; set;}
 
      public void CalcularPedido(int q, double p, double d)
      {
             this.qtde = q;
             this.preco = p;
             this.desconto = d;
             this.total = q * p - d;
      }
}
 
 
class Program
{
      static void Main(string[] args)
      {
             PedidoCompra p = new PedidoCompra();
             p.CalcularPedido(3, 20.00, 5.00);
             Console.WriteLine(p.total);
      }
}