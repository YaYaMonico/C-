using System.Globalization;
 namespace Course{
 class Produto{
 public string Nome;
 public double Preco;
 public intQuantidade;
 public double ValorTotalEmEstoque() {
 returnPreco* Quantidade;
 }
 public void AdicionarProdutos(int quantidade) {
 Quantidade += quantidade;
 }
 public void RemoverProdutos(intquantidade) {
 Quantidade -= quantidade;
 }
 public override stringToString() {
 returnNome
 + ", $ "
 + Preco.ToString("F2", CultureInfo.InvariantCulture)
 + ", "
 + Quantidade
 + " unidades, Total: $ "
 + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
 }
 }
 }