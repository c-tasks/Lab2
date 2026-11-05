using System.Data;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basics and Conditions
            /* Console.WriteLine("Enter the number");
           int x= int.Parse(Console.ReadLine());
           Console.WriteLine(x);*/
            //2
            /* double y = .2 + .23;
           Console.WriteLine(y);*/
            //3
            int x = 5;
            int y = x;
            x = 50;
            Console.WriteLine(x);
            Console.WriteLine(y); 
            
            // lose precision because some decimal values cannot 
            //be represented exactly in binary .lead to reounding errors 
            //4
             /* int principal = 14, rate = 1444, time = 5, interest;
            interest = (principal * rate * time) / 100;
            Console.WriteLine(interest);*/
             //5
             /*  int degree = 10;

            if (degree < 10)
            {
                Console.WriteLine("Just Cold");
            } else if (degree > 30)
            {
                Console.WriteLine("Just Hot");
            }
            else
            {
                Console.WriteLine("Just Good");
            }*/
             //6
            /* int number = int.Parse(Console.ReadLine()) ;
              if(number %3 == 0 && number% 4==0)
              {
                    Console.WriteLine("Yes");
              }
              else
              {
                  Console.WriteLine("NO");
              }*/
            //7
            /* int num1 = int.Parse(Console.ReadLine());
             int num2 = int.Parse(Console.ReadLine());
             int num3 = int.Parse(Console.ReadLine());

             if (num1>num2 && num1> num3)
             {

                 Console.WriteLine($"Max Element :{num1}");

             }else if (num2 > num1 && num2 > num3 )
             {
                 Console.WriteLine($"Max Element :{num2}");

             }
             else
             {
                 Console.WriteLine($"Max Element :{num3}");

             }
             if (num1<num2 && num1 < num3)
             {  
                 Console.WriteLine($"min element : {num1}");
             }
             else if (num2< num1 && num2 < num3)
             {

                 Console.WriteLine($"min element : {num2}");
             }
             else
             { 
                 Console.WriteLine($"min element : {num3}");
             }*/
            //8 the month of year
           /* int month = 1;
            switch (month)

            {
                case 1:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 3:
                    Console.WriteLine(30);
                    break;
                case 4:
                    Console.WriteLine(31);
                    break;
                case 5:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(31);
                    break;
                case 7:
                    Console.WriteLine(30);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                case 12:
                    Console.WriteLine();
                    break;
            }*/

            #endregion

            #region Loops and Numbers
            //9
            /*  int num = int.Parse(Console.ReadLine());
              for (int i= 1; i < num; i++)
              {
                  Console.WriteLine(i);
              }*/
            //10
            /*   int firstNum= int.Parse(Console.ReadLine());
               for (int i = 1; i <= 12; i++)
               {
                   Console.WriteLine(i*firstNum);
               }*/
            //11
            /*int range = int.Parse(Console.ReadLine());
            for (int i = 1; i < range; i++)
            {
                if(i %2==0)
                Console.WriteLine(i);
            }*/
            //12
            /*  int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= num2; i++)
            { 
               result *= num1;
               
            }
             Console.WriteLine(result);*/
            //13 reversed number
            /*  int number = int.Parse(Console.ReadLine());
              int  reseved = 0;
              while(number>0)
              {
                  reseved = (reseved * 10) + number % 10;
                  number /= 10;
              }
              Console.WriteLine(reseved);*/
            //14 prime  number
            /*  int start_range = int.Parse(Console.ReadLine());
              int end_range = int.Parse(Console.ReadLine());


              for ( int i = start_range; i < end_range; i++)
              { 
                  bool isprime=true;
                  for (int j= 2; j < i; j++)
                  {
                      if ( i % j ==0 )
                      {
                         isprime = false;
                          break;
                      }

                  }

               if (isprime && i> 1)
                  {
                      Console.WriteLine(i);
                  }
              } 
               */
            //15 straight line
            /* int x1 = int.Parse(Console.ReadLine());
             int y1 = int.Parse(Console.ReadLine());
             int x2 = int.Parse(Console.ReadLine());
             int y2 = int.Parse(Console.ReadLine());
             int x3 = int.Parse(Console.ReadLine());
             int y3 = int.Parse(Console.ReadLine());
             if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
             {
                 Console.WriteLine("points lie on the same straight line");
             }
             else
             {
                 Console.WriteLine("points do not  lie on the same straight line" );
             }
            */
            //16 matrix 
          /*  int n = int.Parse(Console.ReadLine());
            for (int i= 0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    if (i == j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);   
                    }

                }
                Console.WriteLine();
            }*/

            #endregion

        }
    }
}