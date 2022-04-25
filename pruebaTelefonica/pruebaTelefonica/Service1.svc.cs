using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace pruebaTelefonica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service.svc o Service.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string getCalcularFormulaCuadratica()
        {
            double a, b, c;
            JObject jsonReturn = new JObject();
            try
            {
                a = 2;
                b = 7;
                c = 2;

                FormulaCuantica formulaCuantica = new FormulaCuantica();
                jsonReturn.Add("statusCode", 200);

                return formulaCuantica.Calculate(a, b, c);
            }
            catch (ArgumentException excArgu)
            {
                jsonReturn.Add("Error", excArgu.ToString());
            }
            catch (OutOfMemoryException excMemory)
            {
                jsonReturn.Add("Error", excMemory.ToString());
            }
            catch (TimeoutException excTime)
            {
                jsonReturn.Add("Error", excTime.ToString());
            }
            catch (JsonException execjson)
            {
                jsonReturn.Add("Error", execjson.ToString());
            }
            finally
            {
                a = 0;
                b = 0;
                c = 0;
            }
            return JsonConvert.SerializeObject(jsonReturn);
        }

        public string getListaFibonacci(int param)
        {
            string jsonReturn;
            try
            {
                Fibonacci fibonacci = new Fibonacci();
                return fibonacci.getListFibonacci(param);
            }
            catch (ArgumentException excArgu)
            {
                jsonReturn = "Error " + excArgu.ToString();
            }
            catch (OutOfMemoryException excMemory)
            {
                jsonReturn = "Error " + excMemory.ToString();
            }
            catch (TimeoutException excTime)
            {
                jsonReturn = "Error " + excTime.ToString();
            }
            catch (JsonException execjson)
            {
                jsonReturn = "Error " + execjson.ToString();
            }
            finally
            {

            }
            return jsonReturn;
        }
    }
}