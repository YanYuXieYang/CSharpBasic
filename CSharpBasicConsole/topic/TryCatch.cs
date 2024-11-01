using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.topic
{
    internal class TryCatch
    {
        public TryCatch()
        {
            try
            {
                try
                {
                    int i = 0;
                    object value = 1 / i;
                }
                catch (NullReferenceException Exception)
                {
                    Console.Write("Null Re Ex ");
                }
                finally
                {
                    Console.Write("Clean up ");
                }
            }
            catch
            {
                Console.Write("Generic catch ");
            }
            Console.WriteLine();
        }
    }
}
