using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
  public class FizzBuzz
  {
    // takes a number
    // if divisible by 3, return fizz
    // divisible by 5, return buzz
    // divisible by 3 and 5, return fizzbuzz
    // not divisible by either, return the number
    public static string Convert(int userNum)
    {
      switch (userNum % 15)
      {
        case 0:
          return "fizzbuzz";
        case 5:
        case 10:
          return "buzz";
        case 3:
        case 6:
        case 9:
        case 12:
          return "fizz";
        
        default:
          return userNum.ToString();
      }
    }
  }
}

// what i wrote
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace FizzBuzz
// {
//   public class FizzBuzz
//   {
//     // takes a number
//     // if divisible by 3, return fizz
//     // divisible by 5, return buzz
//     // divisible by 3 and 5, return fizzbuzz
//     // not divisible by either, return the number
//     public static void Main(string[] args)
//     {
//       Console.WriteLine("Enter a number: ");
//       int userNum = Convert.ToInt32(Console.ReadLine());
//       string result = Convert(userNum);
//       Console.WriteLine(result);
//     }
//     public static string Convert(int userNum)
//     {
//       switch (userNum % 15)
//       {
//         case 0:
//           return "fizzbuzz";
//           break;
//         case 5:
//           return "buzz";
//           break;
//         case 10:
//           return "buzz";
//           break;
//         case 3:
//           return "fizz";
//           break;
//         case 6:
//           return "fizz";
//           break;
//         case 9:
//           return "fizz";
//           break;
//         case 12:
//           return "fizz";
//           break;

//         default:
//           return userNum.ToString();
//       }
//     }
//   }
// }