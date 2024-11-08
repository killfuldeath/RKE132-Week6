using System.ComponentModel.DataAnnotations;

string tere = "tere, maailm! Ma olen Henri!";

int stringlength = tere.Length;
char firsletter = tere[0];
Console.WriteLine(firsletter);
tere = tere.Replace(tere[0], char.ToUpper(tere[0])).Replace('!', '?');

tere = tere.Trim();


firsletter = tere[0];
Console.WriteLine(tere);
//int wordcount = 1;

//for (int i = 0; i < tere.Length; i++)
//{
//    if (char.IsWhiteSpace(tere[i]))
//    {
//        wordcount++;
//    }
//} 
