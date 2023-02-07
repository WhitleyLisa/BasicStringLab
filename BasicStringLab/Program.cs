// Basic String Processing Lab
// Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.

//Console.WriteLine("Please enter a sentence! :");
//string userInput = Console.ReadLine();  
////string[] splitList = userInput.Split(",");

//for (int i = 0; i < userInput.Length; i++)
//{
//    Console.Write(userInput[i]);

//}



string splitSentence;
string sentenceSplit = (" ");

Console.WriteLine("Please enter a sentence! :");
splitSentence = Console.ReadLine();
sentenceSplit = splitSentence;

Console.WriteLine("\n");

string[] split = sentenceSplit.Split(' ');
foreach (string item in split)
{
   
    Console.WriteLine(item);
}
Console.ReadLine();
