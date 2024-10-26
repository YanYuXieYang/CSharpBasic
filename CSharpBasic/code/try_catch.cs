﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.code
{
    public class Try_catch
    {
        public Try_catch()
        {
            TryAndFinally taf = new TryAndFinally();
            string ret=taf.hh();
            Console.WriteLine(ret);
        }


        public class TryAndFinally
        {
            public String ff()
            {
                Console.WriteLine("ff()");
                return "111";
            }
            public String hh()
            {
                try
                {
                    return ff();
                }
                catch (Exception e)// 类型必填，不填报错
                {
                    Console.WriteLine("e");
                }
                finally
                {
                    Console.WriteLine("finally");
                }
                return "hh end";
            }
        
        }


    }
}
