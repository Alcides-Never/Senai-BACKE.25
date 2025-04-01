// Abstração - Muito ligada a Herança

// Interface - Contrato
// TrocarMarcha

// Livro (texto, autor, ano)
// Interface -> MostrarDadosLivro
// MostrarLivro() 
// Em geral, escondo e depois explico como ele existe

using Abstracao;

CarroAutomatico carro = new CarroAutomatico();

carro.TrocarMarcha();

CarroManual carro2 = new CarroManual();

carro2.TrocarMarcha();
