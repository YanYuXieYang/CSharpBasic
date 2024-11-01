// See https://aka.ms/new-console-template for more information
using CSharpBasic.code;
using CSharpBasicConsole.code;
using System.Collections;
using System.Text.RegularExpressions;

//主程序入口，执行编写代码即可。VS2022控制台项目，基于.NET8.0，支持跨平台
test();
static void test()
{
    //Test t = new Test();
    ////调用两个方法分别测试拆装箱和不拆装箱执行同样的任务所耗的时间
    //t.Test001();// 4s
    //t.Test002();

    decimal a = 10;
    Console.WriteLine(a);
    a = 10.1M;
    float b = 10.2f;
    double c = 10.3d;
    uint d = 1u;
    long e = 100l;
    ulong f = 11ul;
    Console.WriteLine(b);
    Console.WriteLine(c);

    Console.WriteLine("Hello, World!");
    Console.WriteLine(DateTime.Now);


    Foo foo = null;
    /*
    +运算和??运算，是同级的，从左到右
    foo?N 其中foo为空，故foo?.N为空，而不是我们自己定义只读属性N的默认值1
    2+null,注意结果是int?类型的，结果是null
    null??1,结果即1
        */
    var n = 2 + foo?.N ?? 1;// output：1
    Console.WriteLine(n);
    n = (2 + foo?.N) ?? 5;
    Console.WriteLine(n);
    n = 2 + (foo?.N ?? 5);
    Console.WriteLine(n);
    int[] num = null;
    var str1 = num?[1];
    Console.WriteLine(str1);
    int[] nums2 = { 3, 6, 92, 8 };
    //var str2 = nums2?[8];// 会越界抛异常

    // 声明一个可空的整型
    int? nullableInteger = null;

    // 给可空整型赋值
    //nullableInteger = 10;

    // 使用Value属性获取值，如果为null，则抛出异常
    try
    {
        Console.WriteLine(nullableInteger.Value);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    // 使用HasValue属性检查是否有值
    if (nullableInteger.HasValue)
    {
        Console.WriteLine($"The value is: {nullableInteger.Value}");
    }
    else
    {
        Console.WriteLine("The value is null.");
    }

    new Virtual();

    new NewFunc();
    new NewFunc2();

    new ConstructorFunc();
    new ConstructorFunc2();

    string getChar = "12345";
    char c1 = getChar[1];
    Console.WriteLine(c1);

    var partialClass = new EClass();
    partialClass.Show($"E1={partialClass.E1},E2={partialClass.E2}");

    var r = new AClass();
    r.Name = "abcde";
    Console.WriteLine(r);//输出结果是命名空间+类型：CSharpBasic.code.AClass。若是record记录则会输出类似GRecord { A = abcde, B = 0 }

    new Indexer();

    new Try_catch();
    new Try_catch2();
    new Try_catch3();

    new Out();

    new Operator();

    new Extend1();
    new Extend2();
    new Extend3();

    int[] myArray = { 1, 2, 3, 4, 5 };
    int lengthOfArray = myArray.Length;
    Console.WriteLine(lengthOfArray); // 输出：5

    string sa = "";
    int i = sa.Length;
    byte[] bv = new byte['1'];

    new Equals();

    new MemberwiseClone();

    new Switch();

    short s1 = 1;
    s1 = (short)(s1 + 1);
    s1 += 1;
    Console.WriteLine(s1);

    new Static();

    string inputStr = " xx   x    x ";
    inputStr = Regex.Replace(inputStr.Trim(), @"\s+", " ");// 多个连续空格替换为1个。正则表达式 \s+ 匹配一个或多个空白字符（包括空格、制表符等）
    Console.WriteLine(inputStr);

    ArrayList al = new ArrayList();
    al.Add(45);
    al.Add("78");
    al.Add(true);

}


class Foo
{
    public int N { get; set; } = 1;
}