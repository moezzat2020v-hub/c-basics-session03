
// Assignment-03

// Q1

using System.Text;

string title = "clean code";
string UpperTitle = title.ToUpper();

Console.WriteLine(title);
Console.WriteLine(UpperTitle);

// Q2

string condation01 = "Clean Code";
string condation02 = "Clean Code";

Console.WriteLine(condation01.Equals(condation02));

// Q3

StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");

Console.WriteLine(sb.ToString());

// Q4

StringBuilder sb01 = new StringBuilder();
sb01.Append("Book List");
sb01.Append(" - Updated");
sb01.Replace("Book List", "Library");

Console.WriteLine(sb01.ToString());

// Q5

string title2 = "Clean Code";
int pages2 = 464;
string sentens = "Book: " + title2 + " Pages: " + pages2;
Console.WriteLine(sentens);

// Q6

string title3 = "Clean Code";
int pages3 = 464;
string Sentens = ($"Book : {title3} , pages: {pages3}");
Console.WriteLine(Sentens);

// Q7

string title4 = "Clean Code";
int pages4 = 464;
string SENTENS = string.Format("Book : {0} , pages: {1}", title4, pages4    );
Console.WriteLine(SENTENS);

// Q8

int pages = 464;

if (pages <= 300 && pages != 0)
{
    Console.WriteLine("Short book");
}
else
{
    Console.WriteLine("long book");
}

// Q9

int Pages = 464;
bool isAvailable = true;
if (Pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}

// Q10

string title1 = "Refactoring";
switch (title1)
{
    case "Clean Code": 
        Console.WriteLine("Great choice!"); break;

    case "Refactoring":
        Console.WriteLine("Nice pick!"); break;

    default:
        
        Console.WriteLine("Never heard of it"); break;

}

// Q11   لسة ما اخدنهاش 

int page = 464;

if (page <= 300 && page != 0)
{
    Console.WriteLine("Short book");
}
else
{
    Console.WriteLine("long book");
}

// Q12

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
  for (int i = 0; i < books.Length; i++)
  {
      Console.WriteLine(i+1 + ". " + books[i]);
  }

// Q13

string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
int j = 0;
while ( j < Books.Length)
{
    Console.WriteLine(j + 1 + ". " + Books[j]);
    j++;
}

// Q14

  int z = 0;
  
do
{
    Console.WriteLine("Checking book...");
    z++;
} 
while (z < 3);

// Q15 لسة ما اخدنهوش

// Q16

// Q17

// Q18 