using LinqTutorial;
using LinqTutorial.Model;

namespace LinqTutorial;

public class ProgramMain
{
    public static void Main()
    {
        Product.SampleFilterProduct();
        Product.SampleFilterByName();
        Category.SampleFilterCategory();
    }

    #region Introduction
    public static void IntroductionLinq()
    {
        Console.WriteLine("Introduction without LinQ : ");
        IntroLinq.Introduction();
        Console.WriteLine("\n Intro with Linq");
        IntroLinq.IntroductionWithLinq();
    }
    #endregion
}
