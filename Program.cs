C/* 版本：V1.0
 * 本产品由404和404的大肥鱼开发
 * 相比于V0.7.2版本我们简化了代码结构
 * 解决了很多bug 比如赋值删除不合法却不报错
 * 和删除了很多不必要的代码
 * 将命中检测和错误处理分开
 * 我们还怎加了一些语法 详情见配套资料
 * 代码总量500行 花了我大量时间 
 * 如果你认可我 给我点一个star吧 这对我很重要
 * 后续我会慢慢优化
 * 谢谢
 *                  .-~~~~~~-.
                  .'   .--.   '.
                 /    /    \    \
                |    | ◉  ◉ |    |
                |    |   ︶   |    |
                 \    \____/    /
                  '.          .'
                    '--____--'
             _.-~~~'          '~~~-._
          .-'      永不报错        '-.
         /         永不卡住           \
        |      代码编译永远过          |
         \                            /
          '-._                    _.-'
              '~~~-.        .-~~~'
                   '-.__.-'
                .-~ 莲花宝座 ~-.
               (  ~  ~  ~  ~  )
                '-.________.-'
*/
using System;
using System.Runtime.InteropServices;

namespace ConsoleTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 声明10个存储单位
            string a = "未检测到该字符";
            string b = "未检测到该字符";
            string c = "未检测到该字符";
            string d = "未检测到该字符";
            string e = "未检测到该字符";
            string f = "未检测到该字符";
            string g = "未检测到该字符";
            string h = "未检测到该字符";
            string i = "未检测到该字符";
            string j = "未检测到该字符";

            // 声明10个判断变量
            int a1 = 0;
            int b1 = 0;
            int c1 = 0;
            int d1 = 0;
            int e1 = 0;
            int f1 = 0;
            int g1 = 0;
            int h1 = 0;
            int i1 = 0;
            int j1 = 0;

            Console.WriteLine("这是一个简易编译器 语法详见配套资料 共有10个变量 分别是a到j");

            while (true)
            {
                Console.Write("在控制台内运行：");
                string userInput = Console.ReadLine()!;

                int k = 0; // 错误码：0无错误，1申明不合法，2找不到变量，3不合法的变量，4未知指令
                //int k1 = 0; // 辅助错误码 帮助检测变量合法性
                // ========== 1. 整数变量声明检测 ==========
                switch (userInput)
                {
                    case "int a":
                        a = "0";
                        a1 = 1;
                        Console.WriteLine("已经声明变量a 初始值为0");
                        continue;
                    case "int b":
                        b = "0";
                        b1 = 1;
                        Console.WriteLine("已经声明变量b 初始值为0");
                        continue;
                    case "int c":
                        c = "0";
                        c1 = 1;
                        Console.WriteLine("已经声明变量c 初始值为0");
                        continue;
                    case "int d":
                        d = "0";
                        d1 = 1;
                        Console.WriteLine("已经声明变量d 初始值为0");
                        continue;
                    case "int e":
                        e = "0";
                        e1 = 1;
                        Console.WriteLine("已经声明变量e 初始值为0");
                        continue;
                    case "int f":
                        f = "0";
                        f1 = 1;
                        Console.WriteLine("已经声明变量f 初始值为0");
                        continue;
                    case "int g":
                        g = "0";
                        g1 = 1;
                        Console.WriteLine("已经声明变量g 初始值为0");
                        continue;
                    case "int h":
                        h = "0";
                        h1 = 1;
                        Console.WriteLine("已经声明变量h 初始值为0");
                        continue;
                    case "int i":
                        i = "0";
                        i1 = 1;
                        Console.WriteLine("已经声明变量i 初始值为0");
                        continue;
                    case "int j":
                        j = "0";
                        j1 = 1;
                        Console.WriteLine("已经声明变量j 初始值为0");
                        continue;
                }

                // ========== 2. 变量输出检测 ==========
                switch (userInput)
                {
                    case "print a":
                        Console.WriteLine($"变量 a 的值为: {a}");
                        continue;
                    case "print b":
                        Console.WriteLine($"变量 b 的值为: {b}");
                        continue;
                    case "print c":
                        Console.WriteLine($"变量 c 的值为: {c}");
                        continue;
                    case "print d":
                        Console.WriteLine($"变量 d 的值为: {d}");
                        continue;
                    case "print e":
                        Console.WriteLine($"变量 e 的值为: {e}");
                        continue;
                    case "print f":
                        Console.WriteLine($"变量 f 的值为: {f}");
                        continue;
                    case "print g":
                        Console.WriteLine($"变量 g 的值为: {g}");
                        continue;
                    case "print h":
                        Console.WriteLine($"变量 h 的值为: {h}");
                        continue;
                    case "print i":
                        Console.WriteLine($"变量 i 的值为: {i}");
                        continue;
                    case "print j":
                        Console.WriteLine($"变量 j 的值为: {j}");
                        continue;
                }

                // ========== 3. put up 命令检测 ==========
                if (userInput == "put up")
                {
                    Console.WriteLine("这是10个变量的值");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(d);
                    Console.WriteLine(e);
                    Console.WriteLine(f);
                    Console.WriteLine(g);
                    Console.WriteLine(h);
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    continue;
                }



                //新语法往这里加↓
                // ========== 5. rm up 命令检测 ==========
                if (userInput == "rm up")
                {
                    a = "未检测到该字符";
                    b = "未检测到该字符";
                    c = "未检测到该字符";
                    d = "未检测到该字符";
                    e = "未检测到该字符";
                    f = "未检测到该字符";
                    g = "未检测到该字符";
                    h = "未检测到该字符";
                    i = "未检测到该字符";
                    j = "未检测到该字符";
                    a1 = 0;
                    b1 = 0;
                    c1 = 0;
                    d1 = 0;
                    e1 = 0;
                    f1 = 0;
                    g1 = 0;
                    h1 = 0;
                    i1 = 0;
                    j1 = 0;
                    Console.WriteLine("已清空所有变量");
                    continue;
                }
                // ========== 6. rm x 命令检测 ==========
                switch (userInput)
                {
                    case "rm a":
                        if (a1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量a");
                            a = "未检测到该字符";
                            a1 = 0;
                            continue;
                        }
                    case "rm b":
                        if (b1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量b");
                            b = "未检测到该字符";
                            b1 = 0;
                            continue;
                        }
                    case "rm c":
                        if (c1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量c");
                            c = "未检测到该字符";
                            c1 = 0;
                            continue;
                        }
                    case "rm d":
                        if (d1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量d");
                            d = "未检测到该字符";
                            d1 = 0;
                            continue;
                        }
                    case "rm e":
                        if (e1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量e");
                            e = "未检测到该字符";
                            e1 = 0;
                            continue;
                        }
                    case "rm f":
                        if (f1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量f");
                            f = "未检测到该字符";
                            f1 = 0;
                            continue;
                        }
                    case "rm g":
                        if (g1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量g");
                            g = "未检测到该字符";
                            g1 = 0;
                            continue;
                        }
                    case "rm h":
                        if (h1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量h");
                            h = "未检测到该字符";
                            h1 = 0;
                            continue;
                        }
                    case "rm i":
                        if (i1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量i");
                            i = "未检测到该字符";
                            i1 = 0;
                            continue;
                        }
                    case "rm j":
                        if (j1 == 0)
                        {
                            Console.WriteLine("报错：没有在存储中找到该变量");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("已经删除变量j");
                            j = "未检测到该字符";
                            j1 = 0;
                            continue;
                        }
                }
                // 新语法往这里加↑
                // ========== 4. 变量赋值检测 ==========
                if (userInput.Contains('='))
                {
                    int eqIndex = userInput.IndexOf('=');
                    string varName = userInput.Substring(0, eqIndex).Trim();
                    string value = userInput.Substring(eqIndex + 1).Trim();
                    if (varName.Length == 1)
                    {
                        char x = varName[0];
                        switch (x)
                        {
                            case 'a':
                                if (a1 == 1)
                                {
                                    a = value;
                                    Console.WriteLine($"变量 a 被赋值为: {a}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'b':
                                if (b1 == 1)
                                {
                                    b = value;
                                    Console.WriteLine($"变量 b 被赋值为: {b}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'c':
                                if (c1 == 1)
                                {
                                    c = value;
                                    Console.WriteLine($"变量 c 被赋值为: {c}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'd':
                                if (d1 == 1)
                                {
                                    d = value;
                                    Console.WriteLine($"变量 d 被赋值为: {d}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'e':
                                if (e1 == 1)
                                {
                                    e = value;
                                    Console.WriteLine($"变量 e 被赋值为: {e}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'f':
                                if (f1 == 1)
                                {
                                    f = value;
                                    Console.WriteLine($"变量 f 被赋值为: {f}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'g':
                                if (g1 == 1)
                                {
                                    g = value;
                                    Console.WriteLine($"变量 g 被赋值为: {g}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'h':
                                if (h1 == 1)
                                {
                                    h = value;
                                    Console.WriteLine($"变量 h 被赋值为: {h}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'i':
                                if (i1 == 1)
                                {
                                    i = value;
                                    Console.WriteLine($"变量 i 被赋值为: {i}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            case 'j':
                                if (j1 == 1)
                                {
                                    j = value;
                                    Console.WriteLine($"变量 j 被赋值为: {j}");
                                    continue;
                                }
                                else
                                {
                                    k = 3;
                                }
                                break;
                            default:
                                k = 3; // 变量名不是 a 到 j
                                break;
                        }
                    }
                    else
                    {
                        k = 3; // 变量名长度不为1
                    }
                }
                else
                {
                    // ========== 5. 未匹配任何命令时，判断错误类型 ==========
                    if (userInput.StartsWith("int "))
                    {
                        k = 1;
                    }
                    else if (userInput.StartsWith("print "))
                    {
                        k = 2;
                    }
                    else if (userInput.StartsWith("rm "))
                    {
                        k = 3;
                    }
                    else if (userInput.StartsWith("rm "))
                    {
                        k = 3;
                    }
                    else if (userInput.StartsWith("put "))
                    {
                        k = 3;
                    }
                    else
                    {
                        k = 4;
                    }
                }

                // ========== 6. 统一的命中检测（错误处理） ==========
                if (k == 1)
                {
                    Console.WriteLine("报错：申明不合法变量");
                }
                else if (k == 2)
                {
                    Console.WriteLine("报错：没有在存储中找到该变量");
                }
                else if (k == 3)
                {
                    Console.WriteLine("报错：不合法的对象");
                }
                else if (k == 4)
                {
                    Console.WriteLine("报错：" + userInput + "是未知的指令 请确认拼写后重试");
                }
            }
        }
    }
}
