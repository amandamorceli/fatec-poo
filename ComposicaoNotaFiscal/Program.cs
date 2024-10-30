//main

using ComposicaoNotaFiscal;

ItemNotaFiscal i1 = new ItemNotaFiscal(10);
ItemNotaFiscal i2 = new ItemNotaFiscal(3);

NotaFiscal nf = new NotaFiscal(1, "11/09/2024"); // 
nf.Itens.Add(i1);
nf.Itens.Add(i2);

nf = null; // forçando a destruição da instância
GC.Collect(); // forçando chamada do coletor de lixo e consequentemente o destrutor