using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/* Program Name:     Ch16Ex3.cs                                          */
/* Date:             05/01/2022                                      	 */
/* Programmer:       Miranda Morris                                      */
/* Class:            CSCI 234                               		     */
/*                                                                       */
/* Program Description: The purpose of this program is to compare two    */
/* strings. It is meant to output whether the first string is less than, */
/* equal to, or greater than the second string.                          */
/*                                                                       */
/*                                                                       */
/* Input: The user inputs two strings (one is named a, one is named b)   */
/*                                                                       */
/*                                                                       */
/* Output: There are three different text outputs that can occur such as:*/
/*               String a is equal String b                              */
/*               String a is less than String b                          */
/*               String a is greater than string b                       */
/* Givens: None							                                 */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data:                                          */
/*              string a = 1234 string b = 874245;                       */
/*              string a = 17521 string b = 122                          */
/*              string a = 1234 string b = 1234                          */
/*                                                                       */
/* List the Testing Output Data:                                         */
/*            string a is less than string b;                            */
/*            string a is greater than string b;                         */
/*            string a is equal to string b;                             */
/*                                                                       */
/*                                                                       */
/*************************************************************************/

namespace ch16ex3
{
    class ch16ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter another string:");
            string b = Console.ReadLine();

        if  (a.CompareTo(b) == 0)
            {
                Console.WriteLine("String a is equal String b");
            }
        else if (a.CompareTo(b) < 0)
            {
                Console.WriteLine("String a is less than String b");
            }
        else if (a.CompareTo(b) > 0)
            {
                Console.WriteLine("String a is greater than string b");
            }

        }
    }
}
