using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaTelefonica
{
    public class Fibonacci
    {
        public string getListFibonacci(int param)
        {
            string array = "0";

            try
            {

                int a, b, limite, i, auxiliar;


                a = 0;
                b = 1;

                for (i = 0; i < param - 1; i++)
                {
                    auxiliar = a;
                    a = b;
                    b = auxiliar + a;
                    array = array + " " + a + " ";
                }

                return array;

            }
            catch (ArgumentException excArgu)
            {
                array = "Error " + excArgu.ToString();
            }
            catch (OutOfMemoryException excMemory)
            {
                array = "Error " + excMemory.ToString();

            }
            catch (TimeoutException excTime)
            {
                array = "Error " + excTime.ToString();

            }
            catch (JsonException execjson)
            {
                array = "Error " + execjson.ToString();

            }
            finally
            {

            }

            return array;

        }
    }
}