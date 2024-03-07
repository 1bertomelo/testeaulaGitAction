using Calculadora.Core;

namespace Calculadora.Tests
{
	public class CalculadoraUnitTest
	{
		[Theory]
		[InlineData(2,3,5)]
		[InlineData(20,35,55)]
		[InlineData(10,15,25)]
		public void Calculadora_SomarDoisNumeros_ObterSoma
			(int n1,int n2,int resultado)
		//Padrao de nome
		//Objeto_Acao_ResultadoEsperado
		{ 
			int resultadoSoma = Calculadoras.Somar(n1,n2);

			Assert.Equal(resultado, resultadoSoma);

		}

		[Theory]
		[InlineData(3, 2, 1)]
		[InlineData(40, 35, 5)]
		[InlineData(100, 15, 85)]
		public void Calculadora_SubtrairDoisNumeros_ObterSubtracao
			(int n1, int n2, int resultado)
		//Padrao de nome
		//Objeto_Acao_ResultadoEsperado
		{
			int resultadoSubtracao = Calculadoras.Subtrair(n1, n2);

			Assert.Equal(resultado, resultadoSubtracao);

		}


		[Theory] 
		[InlineData(3, 2, 6)]     
		[InlineData(4, 3, 12)]
		[InlineData(5, 5, 25)]
		public void Calculadora_MultiplicarDoisNumeros_ObterMultiplicacao
			(int n1, int n2, int resultado)
		//Padrao de nome
		//Objeto_Acao_ResultadoEsperado
		{
			int resultadoMultiplicacao = Calculadoras.Multiplicar(n1, n2);

			Assert.Equal(resultado, resultadoMultiplicacao);

		}

		[Fact]
		public void Calculadora_DividirPorZero_ObterExcecao()
		{
		  var resultadoExcecao = Assert.Throws<Exception>(()
			  =>	Calculadoras.Divisao(10, 0));

			Assert.Equal("N�o � poss�vel dividir por Zero", resultadoExcecao.Message);

		} 

	}
}