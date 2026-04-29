Console.WriteLine("");

try
{
   
    Console.Write("请输入第一个数：");
    double num1 = double.Parse(Console.ReadLine()!); 

    
    Console.Write("请输入运算符（+ - * /）：");
    string op = Console.ReadLine()!;

    
    Console.Write("请输入第二个数：");
    double num2 = double.Parse(Console.ReadLine()!);

    
    double result;
    bool isSuccess = true; 

    switch (op)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
           
            if (num2 == 0)
            {
                Console.WriteLine("");
                isSuccess = false;
                break;
            }
            result = num1 / num2;
            break;
        default:
            Console.WriteLine("");
            isSuccess = false;
            break;
    }

    if (isSuccess)
    {
        Console.WriteLine($" 计算结果：{num1} {op} {num2} = {result}");
    }
}
catch (FormatException)
{
    Console.WriteLine("");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}

Console.WriteLine("");
Console.ReadKey();