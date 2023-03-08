namespace MomentoHandsOn	
{
	internal class Program
	{
		/*Escreva  um  programa  com uma função que solicita a digitação do salário atual de um funcionário
		 * e o índice de reajuste. Exiba o salário reajustado. Faça o retorno do resultado
		*/
		public static double calcularReajuste()
		{
			double salarioAtual, indiceReajuste, salarioReajustado;
			Console.WriteLine("Digite o salário atual do funcionário: R$ ");
			salarioAtual = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o índice de reajuste do salário: ");
			indiceReajuste = double.Parse(Console.ReadLine());
			salarioReajustado = salarioAtual + (salarioAtual * indiceReajuste / 100);
			return salarioReajustado;
		}
		/*Faça um programa com uma função que recebe por parâmetro a idade de um nadador. 
		 * Classifique-o em uma das seguintes categorias:- Infantil A = 5 a 7 anos- Infantil B = 8 a 11 anos- 
		 * Juvenil A = 12 a 13 anos- Juvenil B = 14 a 17 anos-Adultos = Maiores de 18 anos
		 * Faça o retorno do resultado
		 */
		public static string classificacao(int idade)
		{
			string categoria ;
			if (idade >= 5 && idade <= 7)
				categoria = "Infantil A";
			else if (idade > 7 && idade <= 11)
				categoria = "Infantil B";
			else if (idade > 11 && idade <= 13)
				categoria = "Juvenil A";
			else if (idade > 13 && idade <= 17)
				categoria = "Juvenil B";
			else if (idade >= 18)
				categoria = "Adulto";
			else
				categoria = "";

			return categoria ;
		}
		
		static void Main(string[] args)
		{
			
			Console.WriteLine("Momento Hands On");
			Console.WriteLine("Salario Reajustado: {0:c}", calcularReajuste());

			Console.WriteLine("Categoria do nadador");
			Console.WriteLine("Digite a idade do nadador");
			int idade = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Categoria: " + classificacao(idade));

		}
		
	}
}