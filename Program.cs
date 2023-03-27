using System;
using System.Linq;

namespace DesafioForca
{
    class Desafio1
    {
        static void Main(string[] args)
        {
            // 1. Gerar uma lista/vetor de palavras

            string[] flowers =
            {
                "margarida",
                "azaleia",
                "amarilis",
                "hortensia",
                "gardenia",
                "iris",
                "magnolia",
                "perpetua",
                "miosotis",
                "dalia"
            };

            // 2. Selecione uma palavra da lista de forma randômica

            Random randomWord = new Random();
            string secretWord = flowers[randomWord.Next(flowers.Length)];

            // 3. Separar as letras da palavra em um vetor (onde cada posição é uma letra)
            char[] wordArray = secretWord.ToCharArray();

            // 4. Criar uma estrutura de repetição que mostre na tela o seguinte output: Ex. para a palavra Marmelo, exibir _______
            Console.WriteLine("Jogo da Forca\n");

            char[] outputArray = new char[wordArray.Length];
            for (int i = 0; i < wordArray.Length; i++)
            {
                outputArray[i] = '_';
                Console.Write(outputArray[i] + " ");
            }

            while ((Enumerable.SequenceEqual(outputArray, wordArray)) == false)
            {

                // 5. Criar prompt para receber a letra do usuário

                Console.Write("\n\nInforme uma letra: ");
                string letter = Console.ReadLine().ToLower();
                Console.Write("\n");

                // 6. Percorrer o vetor conferindo se a letra digitada pelo usuário existe na palavra selecionada

                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (wordArray[i].Equals(char.Parse(letter)))
                    {
                        outputArray[i] = wordArray[i];
                    }
                }

                // 7. Se existir, preencha o output com a letra correspondente

                foreach (char letra in outputArray)
                {
                    Console.Write(letra + " ");
                }
            }

            // 8. Quando a palavra for acertada, deve terminar o programa com a mensagem "arabéns você acertou a palavra"
            // 
            Console.Write("\n\nParabéns você acertou a palavra");
        }
    }
}
