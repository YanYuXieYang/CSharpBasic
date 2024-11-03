using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicConsole.code
{
    /// <summary>
    /// 特性的反射使用
    /// </summary>
    internal class AttributeReflection
    {
        public AttributeReflection() {
            var fee = new Fee(name: "阿莫西林", createOn: DateTime.Now, amount: 12.5m);
            Console.WriteLine(fee);//输出：阿莫西林|12.5000|20241103155911
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class FormateAttribute : Attribute
        {
            public FormateAttribute(int sn)
            {
                SN = sn;
            }
            public int SN { get; init; }
            public string? DataFormate { get; set; }
        }
        public class Fee : Entity
        {
            public Fee(string name, decimal amount, DateTime createOn)
            {
                Name = name;
                Amount = amount;
                CreateOn = createOn;
            }
            [Formate(1)]
            public string Name { get; set; }
            [Formate(3, DataFormate = "yyyyMMddHHmmss")]
            public DateTime CreateOn { get; set; }
            [Formate(2, DataFormate = "0.0000")]
            public decimal Amount { get; set; }
        }

        /// <summary>
        /// 抽象类Entity
        /// </summary>
        public abstract class Entity
        {
            public override string ToString()
            {
                var type = this.GetType();
                var sortDic = new SortedDictionary<int, string>();
                var propertyList = type.GetProperties();
                //按顺序获取属性
                foreach (var propertyInfo in propertyList)
                {
                    var attrs = propertyInfo.GetCustomAttributes(true);
                    foreach (var attr in attrs)
                    {
                        if (attr is FormateAttribute)
                        {
                            var formateAttr = attr as FormateAttribute;
                            if (formateAttr != null && propertyInfo != null)
                            {
                                var proObj = propertyInfo.GetValue(this, null);
                                if (!string.IsNullOrWhiteSpace(formateAttr?.DataFormate))
                                {
                                    if (proObj != null)
                                    {
                                        var toStringMethod = propertyInfo?.PropertyType?.GetMethod("ToString", new Type[] { typeof(string) });
                                        sortDic.Add(formateAttr.SN, toStringMethod?.Invoke(proObj, new object[] { formateAttr?.DataFormate })?.ToString());
                                    }
                                }
                                else
                                {
                                    if (proObj != null)
                                    {
                                        sortDic.Add(formateAttr.SN, proObj?.ToString());
                                    }
                                }
                                continue;
                            }
                        }
                    }
                }
                var contentBuilder = new StringBuilder();
                foreach (var item in sortDic)
                {
                    contentBuilder.Append($"{item.Value}|");
                }
                return contentBuilder.ToString().TrimEnd('|');
            }
        }
    }
}
