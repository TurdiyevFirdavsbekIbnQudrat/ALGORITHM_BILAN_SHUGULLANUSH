
// ACMP 79
using ALGORITHM_BILAN_SHUGULLANUSH;
using System;
/*
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int x1, y1, sonSaqla;
            x1 = Convert.ToInt32(str[0]);
            y1 = Convert.ToInt32(str[1]);
            int count = 2;
            int sum = 1;
            sonSaqla = x1;
            if (y1 == 1) { Console.WriteLine(x1 % 10); }
            else if (y1 == 0) { Console.WriteLine(1); }
            else
            {
                while (y1 > 1)
                {
                    x1 = (x1 % 10 * x1 % 10) % 10;
                    count *= 2;
                    if (count > y1)
                    {
                        y1 -= count / 2;
                        count = 2;
                        sum *= x1;
                        x1 = sonSaqla;
                    }
                    if (y1 == 1)
                    {
                        sum *= x1 % 10;
                        break;
                    }

                }

                sum %= 10;
                Console.WriteLine(sum);
            }
        }
    }
}*/
/*//ACMP 14
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            long  x1, y1,EKUK_EKUB;
            x1 = Convert.ToInt32(str[0]);
            y1 = Convert.ToInt32(str[1]);
            EKUK_EKUB = x1 * y1;
            while(y1 > 0)
            {
                x1 = x1 % y1;
                long saqla = x1;
                x1 = y1;
                y1 = saqla;
            }
            Console.WriteLine(EKUK_EKUB / x1);
        }
    }
}
*/
/*
// ACMP 148
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            long x1, y1;
            x1 = Convert.ToInt32(str[0]);
            y1 = Convert.ToInt32(str[1]);
            while (y1 > 0)
            {
                x1 = x1 % y1;
                long saqla = x1;
                x1 = y1;
                y1 = saqla;
            }
            Console.WriteLine( x1);
        }
    }
}
*/
/*
LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });
var salom = people.First;
people.AddAfter(salom , "Togo");
foreach(var item in people)
{
    Console.WriteLine(item);
    
}*/
// от начала до конца списка

/*
 LinkedList<int> l1 = new LinkedList<int>(new[] { 1, 2, 3,1 });
LinkedList<int> l2 = new LinkedList<int>(new[] { 9, 9, 9 });

int dildagiSon=0;
string result="";

if (l1.Count < l2.Count) {
     var next = l1;
     l1 = l2;
     l2 = next;
}

while (l1.Count != 0)
    {
    if (l2.Count != 0)
    {
        result = Convert.ToString((l1.Last.Value + l2.Last.Value + dildagiSon) % 10) + result;
        dildagiSon = (l1.Last.Value + l2.Last.Value) / 10;
    }
    else
    {
        result = Convert.ToString((l1.Last.Value + dildagiSon) % 10) + result;
        dildagiSon = (l1.Last.Value) / 10;

    }
 l1.RemoveLast();
        if(l2.Count!= 0)
           l2.RemoveLast();
    }


if(dildagiSon!=0)
    result = Convert.ToString(dildagiSon) + result;
Console.WriteLine(result);
var a= new List<int>();
foreach (int i in result)
{
    a.Add(Convert.ToInt32(i));
}
LinkedList<int> newLinkedList = new LinkedList<int>(a);
*/
/*
int[] nums = { -2, 4, 5, 6, 2, -1, -7 };
int target = 2;
if (nums.Length == 3)
{
    //return nums[0] + nums[1] + nums[2];
}
int start = 0,left,right;
int min = Math.Abs(nums[0] + nums[1] + nums[2]-target), minNum= nums[0] + nums[1] + nums[2];
for(int i=0; i < nums.Length-2; i++)
{
    for(int j=i+1; j<nums.Length-1; j++)
    {
        for(int k=j+1; k < nums.Length; k++)
        {
            if (Math.Abs(nums[i] + nums[k] + nums[j]-target) < min)
            {
                min = Math.Abs(nums[i] + nums[k] + nums[j]-target);
                minNum = nums[i] + nums[k] + nums[j];
            }
        }
    }
}
//return minNum;
Console.WriteLine(minNum);
*/
/*
Dictionary<int,string> Raqam = new Dictionary<int,string>();
Raqam.Add(2, "abc");
Raqam.Add(3, "def");
Raqam.Add(4, "ghi");
Raqam.Add(5, "jkl");
Raqam.Add(6, "mno");
Raqam.Add(7, "pqrs");
Raqam.Add(8, "tuv");
Raqam.Add(9, "wxyz");
*/
/*
using System.Collections.Specialized;
using System.Globalization;
var f=new List<int>() { 1,2,3,4,5};
LinkedListNode<int> head =new LinkedListNode<int>(1) ;
int n = 2;
List<int> l = new List<int>();
var next = head.First;
while (next != null)
{
    l.Add(next.Value);
    head.RemoveFirst();
    next = head.First;
}
l.RemoveAt(n-1);
foreach(var i in l) 
Console.WriteLine(i);

*/
/*
Console.WriteLine("Debugmi yoki release");
#if (DEBUG)
Console.WriteLine("Bu Debugging holatda");
#elif (RELEASE)
Console.WriteLine("Bu Release holatda");
#endif
*/
/*
var a = String.Format("{0} {1} dan kattami yoki {1} {0} dan kattami", 1, 2);
Console.WriteLine(a);
var b = $"{7}+{5}={12}";
Console.WriteLine(b);
var c = 1+"+"+2+"="+3;
Console.WriteLine(c);
*/
/*
int a;
a=Convert.ToInt32(Console.ReadLine());
string s=a.ToString();
bool isPolindrom = true;
for (int i = 0, d = s.Length-1; i < d; i++, d--)
{
    if (s[i]!=s[d])
    {
        isPolindrom = false;
        break;
    }
} 
if (isPolindrom==true)
{
    Console.WriteLine("bu Polindrom son");
}
else
{
    Console.WriteLine("bu polindrom emas");
}*/
/*
int a,b=0,i;
a = Convert.ToInt32(Console.ReadLine());
int x = a < 0 ? -1:1;
i=a.ToString().Length-1;

while (a != 0)
{
    b += (a % 10) * Convert.ToInt32(Math.Pow(10, i));
    a =a/10;
    i--;
}
if (x == -1) b /= 10;
Console.WriteLine(b);
*/
/*
int a;
a = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < a*2-1; i++)
{
    int d = i;
    if (i >= a)
    {
        d = a * 2 - i-2;
    }
    
    for(int j = 1; j < a*2; j++)
    {
        if ((a - d <= j) && ((a+d) >= j) )
        {
            Console.Write('*');
        }
        else
        {
            Console.Write(' ');
        }
    }
    Console.WriteLine();
}
*/
/*
int a;
a = Convert.ToInt32(Console.ReadLine());
void yulduzchalar(int a)
{
    for(int i = 0; i < a; i++) Console.Write('*');
}
for(int i = 0; i < a; i++)
{
    if (i == 0)
    {
        yulduzchalar(a);
    } 
    else if(i==(int)((a)/2)) 
    {
        yulduzchalar((a + 1) / 2 + 1);
    }
    else 
    {
        yulduzchalar(1); 
    }
    Console.WriteLine();
}
*/
/*
dynamic s= new dynamic[]{1,"sad",3,true,5,6};
Array.Sort(s);
*/
/*
var user = new Person<string, int>("Firdavs",12);
var chiqar = new UserChiqaruvchi();
chiqar.YoshVaIsm(user.Age,user.First);
class Person<TSource,T1Source>
{
    public Person(TSource firstname , T1Source age)
    {
        First =firstname;
        Age =age;
    }
    public TSource First { get; set; }
    public T1Source Age { get; set; }
}
class UserChiqaruvchi
{
    public void YoshVaIsm(int Age,string name)
    {
        Console.WriteLine("{0}  {1}" ,name,Age);
    }
}
*/

using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;

namespace s
{
    public class s
    {
        static void Main(string[] args)
        {

            int[][] Ar1 = new int[3][];
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 31 };
            jaggedArray[1] = new int[] { 28, 29 };
            jaggedArray.AddElement(1, 7);
            int j = 0;
            foreach (var item in jaggedArray)
            {
                foreach (var i in item)
                    Console.WriteLine(i);
                j++;
            }
            Console.WriteLine(j);
        }

        }
    }


//##############################################
/*
ListNode prev = null;
ListNode next= null;
ListNode curr = head;

next = head.Last;
while(next!= null)
{
    next = head.Last;
    head1.AddLast(next);
    if(head.Count!=0)
        head.RemoveLast();
}

Console.WriteLine(head);
*/