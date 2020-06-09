using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Generics_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ArrayList   *
            //// List of ArrayList
            //// List<>
            //// HashSet
            //// Dictonary
            //// 2D Array

            ///ArrayList
            /*
                        ArrayList list = new ArrayList();
                        list.Add(0);
                        list.Add(1);
                        list.Add(2);

                         foreach(var item in list)
                         {
                             Console.WriteLine(item);
                         }

                        Object[] ob = list.ToArray();

                          for(int i = 0; i < ob.Length; i++)
                          {
                              Console.WriteLine(ob[i]);
                          }
                       */

            /* ArrayList[] list = new ArrayList[5];

             for(int i = 0; i < 5; i++)
             {
                 list[i] = new ArrayList();
             }

             list[0].Add("Shamsi");
             list[0].Add("Miju");
             list[0].Add("Anik");

             list[1].Add("153-35-1366");
             list[1].Add("153-35-1332");
             list[1].Add("153-35-1337");

             list[2].Add("Savar");
             list[2].Add("Kallanpur");
             list[2].Add("Kallanpur");

             list[3].Add("01762120546");
             list[3].Add("01686722940");
             list[3].Add("01990251270");

             list[4].Add("Dhaka");
             list[4].Add("Jessore");
             list[4].Add("Jessore");

             Console.WriteLine("Name    ID    Address    Phone Number     City ");

             for(int i = 0; i < list[0].Count; i++)
             {
                 Console.Write(list[0][i] +" ");
                 Console.Write(list[1][i] +" ");
                 Console.Write(list[2][i] +" ");
                 Console.Write(list[3][i] +" ");
                 Console.Write(list[4][i]+" ");
                 Console.WriteLine();
             }
             */


            /*   List<Information> info = new List<Information>();

               var data = new Information()
               {
                   Name = "Shamsi",
                   ID = "153-35-1366",
                   Address = "Savar",
                   Phone = "01762120546",
                   City = "Dhaka",
               };

               var data1 = new Information()
               {
                   Name = "Miju",
                   ID = "153-35-1332",
                   Address = "Kallanpur",
                   Phone = "10990251270",
                   City = "Jessore",
               };

               info.Add
               (
               new Information 
               { Name = "Anik", ID = "153-35-1337", Phone = "007", Address = "Kallanpur", City = "Rajshahi" 
               });

               info.Add(data);
               info.Add(data1);

               foreach (var item in info)
               {
                   Console.Write(item.Name +" ");
                   Console.Write(item.ID + " ");
                   Console.Write(item.Address + " ");
                   Console.Write(item.Phone + " ");
                   Console.Write(item.City + " ");
                   Console.WriteLine();
               }

               for(int i = 0; i < info.Count; i++)
               {
                   Console.Write(info[i].Name + " ");
                   Console.Write(info[i].ID + " ");
                   Console.Write(info[i].Address + " ");
                   Console.Write(info[i].Phone + " ");
                   Console.Write(info[i].City + " ");
                   Console.WriteLine();

               }

               ///Console.WriteLine(info);
               */


            //HashSet<Object> hs = new HashSet<Object>();

            //hs.Add(1);
            //hs.Add("Shamsi");
            //hs.Add(1);

            //Console.WriteLine("SS: "+hs.Count);

            //foreach (var item in hs)
            //{
            //    Console.WriteLine(item);
            //}

            //Object[] ob = hs.ToArray();

            //for (int i = 0; i < hs.Count; i++)
            //{
            //    Console.WriteLine(ob[i]);
            //}



            /*    HashSet<Information> hs = new HashSet<Information>();

              hs.Add
              (
              new Information
              {
                  Name = "Miju",
                  ID = "153-35-1332",
                  City = "Dhaka",
                  Address = "Kallanpur",
                  Phone = "009"
              });

                hs.Add
               (
               new Information
               {
                   Name = "Miju",
                   ID = "153-35-1332",
                   City = "Dhaka",
                   Address = "Kallanpur",
                   Phone = "009"
               });

                Console.WriteLine(hs.Count);

                foreach(var item in hs)
                {
                    Console.Write(item.Name + " ");

                }
                */

            /*  Dictionary<String, String> dict = new Dictionary<String, String>();
              dict.Add("153-35-1332", "Miju Ahamed");
              dict.Add("153-35-1337", "Anik Sarkar");
              dict.Add("153-35-1366", "Washiq Anwar");

              foreach (var item in dict)
              {
                  Console.WriteLine(item.Key + " = " + item.Value);
              }

              for (int i=0;i<dict.Count;i++)
              {
                  Console.WriteLine(dict.Keys.ElementAt(i) + " = " + dict[dict.Keys.ElementAt(i)]);
              }

              ///   Console.WriteLine(dict["153-35-1366"]);
              */

         /*   int[,] value = new int[5,5];

            for(int i = 0; i < 5; i++)
            {
                value[i,i] = i;
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(value[i,i]);
            }
            */

            Console.ReadKey();

        }
    }
    //public  class Information
    //{
    //    public  String Name { set; get; }

    //    public  String ID { set; get; }
    //    public  String Address { set; get; }
    //    public  String Phone { set; get; }
    //    public  String City { set; get; }
    //}
    
}
