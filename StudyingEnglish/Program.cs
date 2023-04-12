using StudyingEnglish.MyPhrases;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Olá, seja bem-vindo a um treinamento de inglês.");
        Console.WriteLine("-----------------------------------------------");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("já sabe como funciona ? ---> Digite (Sim / Não)");
            Console.WriteLine("Se caso quiser sair. ---> Digite (Sair)");
            Console.WriteLine();
            Console.Write("Sua resposta é: ");

            var resposta = Console.ReadLine();
            if (resposta is not null)
                resposta = resposta.ToString().ToLower();

            switch (resposta)
            {
                case "sim":
                    LetsBora();
                    break;
                case "não":
                case "nao":
                    ComoFunciona();
                    break;
                case "sair":
                    Console.WriteLine();
                    Console.WriteLine("Finalizando...");
                    return;
                default:
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Resposta invalida, tente novamente: Aperte (ENTER)");
                    break;
            }
            Console.ReadKey();
        }
    }

    public static void ComoFunciona()
    {
        Console.WriteLine();
        Console.WriteLine("------------COMO FUNCIONA-------------");
        Console.WriteLine("Escolhemos frases aleatórias e você terá que traduzir as frases em (PORTUGUES) ou em (INGlÊS) da maneira correta.");
        Console.Write("Por favor, para que sua frase esteja correta, deverá usar os caracteres especiais, EX: '.', '?', ',', '!' OU qualquer acento nas frases.");
        Console.WriteLine();
        Console.WriteLine("------------EXEMPLOS-------------");
        Console.WriteLine("1 - What's your name? ------> Qual é o seu nome?");
        Console.WriteLine("2 - Eu não estou dormindo agora. ------> I'm not sleeping now.");
        Console.WriteLine();
        Console.WriteLine("Se quiser desistir é so digitar (Sair).");
        Console.WriteLine("Agora vamos colocar em pratica!");
        Console.WriteLine("--------------------------------------");

        LetsBora();
    }

    public static void LetsBora()
    {
        Console.WriteLine();

        var ramdom = new Random();
        var list = new SimplePresentList().List();

        //Preencher em ordem aleatória
        var listaSimplePresents = list.OrderBy(a => ramdom.Next()).ToList();

        Console.WriteLine("Se quiser desistir é só digitar (Sair)");
        Console.WriteLine("------------EXERCICIOS-------------");
        Console.WriteLine();

        //Simple present 
        for (int i = 0; i < listaSimplePresents.Count;)
        {
            while (true)
            {
                Console.WriteLine("Frase: " + listaSimplePresents[i].Value);

                var traducao = Console.ReadLine();
                if (traducao.ToLower().Equals("sair"))
                    return;

                if (listaSimplePresents[i].Description.Trim().ToLower().Equals(traducao.Trim().ToLower()))
                {
                    Console.WriteLine();
                    Console.WriteLine("---------Correto, vamos para o proximo.----------");
                    Console.WriteLine();

                    i++;
                    break;
                }
                else
                {
                    Console.WriteLine("---------Tente novamente----------");
                    Console.WriteLine();
                    break;
                }
            }
        }
        Console.ReadKey();
    }
}