using System;

public class DataGeneric<T>
{
    private T Data;

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223118");
        dataGeneric.PrintData();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<String>("Rakha");
    }
}