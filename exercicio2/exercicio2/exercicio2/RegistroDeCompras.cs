using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main()
        {
            // Criando uma instância da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();

            // Criando algumas instâncias da classe Compra
            Compra compra1 = new Compra(DateTime.Now, "Notebook", 2500.00m);
            Compra compra2 = new Compra(DateTime.Now, "Mouse", 150.00m);
            Compra compra3 = new Compra(DateTime.Now, "Teclado", 200.00m);

            // Adicionando as compras ao registro
            registro.AdicionarCompra(compra1);
            registro.AdicionarCompra(compra2);
            registro.AdicionarCompra(compra3);

            // Listando todas as compras registradas
            registro.ListarCompras();
        }
    }
}
