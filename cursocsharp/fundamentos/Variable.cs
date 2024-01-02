namespace cursocsharp.fundamentos;

public class Variable
{
    private int age = 10;
    private string _name = "Felipe Santos";
    public static void Test()
    {
        Console.WriteLine("Felipe");
    }

    public void Age()
    {
        Console.WriteLine(age);
    }

    public string Name(string name1)
    {
        return this._name = name1;
    }
}