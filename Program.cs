using System;
using System.Text;


namespace Section_8_Working_With_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: "+ firstName);
            Console.WriteLine("Last name: "+ lastName);

            var splitNames = fullName.Split(' ');
            Console.WriteLine("FirstName: "+splitNames[0]);
            Console.WriteLine("LastName: " + splitNames[1]);

            Console.WriteLine(fullName.Replace("Mosh","Moshfegh"));

            if (String.IsNullOrWhiteSpace(""))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
            Console.WriteLine(price.ToString("C"));

            var sentence = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine("Here's the summary: "+ summary);

            var stringBuilder = new StringBuilder("Hello Universe");
            stringBuilder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(stringBuilder);
            Console.WriteLine("Last Character: "+ stringBuilder[stringBuilder.Length-1]);


            var name = "Mosh";

            name.ToUpper();

            Console.WriteLine(name);

           
        }


    }
}
/*
 
   var tutorName = "Mosh";
   
   tutorName[0] = "N";
   
   Console.WriteLine(tutorName);


StringBuilder only provides methods for fast and efficient manipulation of strings.
It doesn't have any methods to search in strings. If you need to search in a string that you're
building using a StringBuilder, you need to cover it to a string first: builder.ToString().IndexOf('M').


 var builder = new StringBuilder("Mosh");
   
   var index = builder.IndexOf('M');
   
   Console.WriteLine(index);
 
 */