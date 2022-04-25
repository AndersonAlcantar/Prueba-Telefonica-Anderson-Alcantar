using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;


namespace pruebaTelefonica
{
    public class FormulaCuantica
    {

        public string Calculate(double a, double b, double c)
        {
            JObject responseCalculate = new JObject();

            double x1;
            double x2;

            try
            {

                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                responseCalculate.Add("Solución 1", x1);
                responseCalculate.Add("Solución 2", x2);

                return JsonConvert.SerializeObject(responseCalculate);
            }
            catch (ArgumentException excArgu)
            {
                responseCalculate.Add("Error", excArgu.ToString());
            }
            catch (OutOfMemoryException excMemory)
            {
                responseCalculate.Add("Error", excMemory.ToString());

            }
            catch (TimeoutException excTime)
            {
                responseCalculate.Add("Error", excTime.ToString());

            }
            catch (JsonException execjson)
            {
                responseCalculate.Add("Error", execjson.ToString());

            }
            finally
            {
                a = 0;
                b = 0;
                c = 0;
            }

            return JsonConvert.SerializeObject(responseCalculate);

        }
    }
}