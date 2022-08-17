// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2
void Method2(string mesage)
{
    Console.WriteLine(mesage);
}
Method2(mesage: "Текст сообщения");

void Method21(string mesage, int count)
{
    int i = 1;
    while (i < count)
    {
        Console.WriteLine(mesage);
        i++;
    }
}
// Method21(mesage: "Текст", count: 4);
// Method21(count: 4, mesage: "новый текст");

// Вид 3
int Method3()
{
    return Data.Time.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string result = Method4(10, "asdf");
Console.WriteLine(result);

// Вид 4
string Method4(int count, string c)
{
    string result = String.Empty;
    for(int i = 0, i < count, i++);
    {
        result = result + c;
    }
    return result;
}

string result = Method4(10, "asdf");
Console.WriteLine(result);


// Цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}")
    }
    Console.WriteLine();
}