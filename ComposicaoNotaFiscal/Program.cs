// função Main()
using ComposicaoNotaFiscal.Models;

ItemNotaFiscal it1 = new ItemNotaFiscal(20);
ItemNotaFiscal it2 = new ItemNotaFiscal(30);
List<ItemNotaFiscal> itens = new List<ItemNotaFiscal>();
itens.Add(it1);
itens.Add(it2);

NotaFiscal nf = new NotaFiscal(1,"19/10/2022",itens);
//destruindo um objeto
nf = null;
GC.Collect();//coletar da memória objetos inutilizados
