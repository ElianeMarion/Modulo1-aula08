using System.Transactions;

namespace Modulo01___Aula08
{
	internal class Program
	{

		public static void lerTemperatura()
		{
			double tc;
			Console.WriteLine("Digite uma temperatura em ºC: ");
			tc = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(tc + "ºC = " + conversaoTemperatura(tc) + "ºF");
		}

		public static double conversaoTemperatura(double celsius)
		{

			double tf = celsius * 1.8 + 32;
			return tf;
			//return celsius * 1.8 + 32;
		}

		public static void lerValores()
		{
			double b, expoente;
			Console.WriteLine("Digite o valor da base: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o valor do expoente: ");
			expoente = Convert.ToDouble(Console.ReadLine());

			//1ªopção de tratamento do resultado
			Console.WriteLine("Resultado = " + calcular(b, expoente));

			// 2ªopção de tratamento do resultado, atribuir em uma variável e exibí-la depois
			double res = calcular(b, expoente);
			Console.WriteLine(res);
		}

		public static double calcular(double bas, double expo)
		{
			double resultado = 1;
			for (int i = 1; i <= expo; i++)
			{
				resultado = resultado * bas; //resultado *= b;
			}
			//Console.WriteLine("Resultado = " + resultado);
			return resultado;
		}

		/*Vamos criar, no nosso programa, uma função chamada validarLogin(), que receba um usuário e uma senha e 
		 * retorne verdadeiro ou falso, dependendo das informações fornecidas.
		 * Para exercitarmos, vamos considerar que o usuário seja admin e a senha seja 123.
		 */
		public static bool validarLogin(string usuario, string pass)
		{
			if (usuario == "admin" && pass == "123")
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		static void Main(string[] args)
		{
			string login, senha;

			Console.WriteLine("Momento HandsOn");



			Console.WriteLine("Digite 1 para conversão de temperatura.\n2 para expoente\n3 para login: ");
			int op = Convert.ToInt32(Console.ReadLine());
			if (op == 1)
			{
				lerTemperatura();
				//conversaoTemperatura();
			}
			else if (op == 2)
			{
				lerValores();
				//calcular();
			}
			else
			{
				Console.WriteLine("Digite o login: ");
				login = Console.ReadLine();
				Console.WriteLine("Digite a senha: ");
				senha = Console.ReadLine();
				//string msg = validarLogin(login, senha) ? "Acesso autorizado, bem vindo!" : "Acesso não autorizado!";
				Console.WriteLine(validarLogin(login, senha) ? "Acesso autorizado, bem vindo!" : "Acesso não autorizado!");
				/*if (validarLogin(login, senha) == true)
					Console.WriteLine("Acesso autorizado, bem vindo!");
				else
					Console.WriteLine("Acesso não autorizado!");*/

			}

			//uma lista: vetor de strings (texto)
			string[] lista = { "Fiap", "Fiap On", "Fiap School" };
			for(int i = 0; i < lista.Length; i++) {
				Console.WriteLine(lista[i]);
			}

			//foreach: utilizado para percorrer arrays (vetor, lista, coleção)
			foreach(string nome in lista)
			{
				Console.WriteLine(nome); 
			}

			//Operador ternário:   var =  condição ? verdadeiro : falso;
			DateTime agora = DateTime.Now;
			Console.WriteLine("Agora: {0}", agora.ToLongDateString());
			string saudacao;

			saudacao = agora.Hour > 12 ? "Boa Tarde" : "Bom dia";
			Console.WriteLine("São {0}  horas", agora.Hour);
			Console.WriteLine(saudacao);

			int idade = 16;
			string mensagem = idade > 18 ? "Maior" : "Menor";

			mensagem = "maior";
			idade = mensagem == "maior" ? 18 : 10;

		}
	}
}