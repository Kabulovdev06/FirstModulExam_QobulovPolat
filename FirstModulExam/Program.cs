using System.Threading.Channels;

namespace FirstModulExam;

class Program
{
      //1


      public static int TwoRooms(List<int> numbers)
      {
            var counter = 0;
            foreach (var number in numbers)
            {
                  if (number > 9 && number < 100)
                  {
                        counter++;
                  }
            }

            return counter;
      }

      public static List<int> FillAndGetList(int length)
      {
            var digits = new List<int>();
            for (int i = 0; i < length; i++)
            {
                  Console.Write($"{i} : ");
                  var number = int.Parse(Console.ReadLine());
                  digits.Add(number);
            }

            return digits;
      }


      //2

      public static string RemoveLengthTwo(string text)
      {
            text = text.Remove(text.Length - 2, 2);
      
            return text;
      }

      

      //4

      // public static bool StartQovunEndQovun(string text)
      // {
      //
      //       bool StartQovun = text.StartsWith("Qovun");
      //       bool EndQovun = text.EndsWith("Qovun");
      //       return StartQovun && EndQovun;
      // }

      static void Main(string[] args)
      {
            
            //1
            
            
            // Console.Write("Enter length : ");
            // var length = int.Parse(Console.ReadLine());
            // var numbers = FillAndGetList(length);
            // var result = TwoRooms(numbers);
            // Console.WriteLine(result);


            //2

            // Console.Write("Enter text:");
            // var text = Console.ReadLine();
            //
            // var result = RemoveLengthTwo(text);
            // Console.WriteLine(result);


            //4

            // Console.Write("Enter Qovun text:");
            // var text = Console.ReadLine();
            //
            // var result = startQovunEndQovun(text);
            // Console.WriteLine(result);
            
            
      }
}