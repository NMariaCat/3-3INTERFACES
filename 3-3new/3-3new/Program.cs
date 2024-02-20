using _3_3new;

public class Program

{
    static void Main()
    {
        IBase[] arr = new IBase[3];
        arr[0] = new OneDimentionArr();
        arr[1] = new TwoDimentionArr();
        arr[2] = new SteppedArr();
        for (int i = 0; i < 3; i++)
        {
            arr[i].countAverage();
            ((IPrinter)arr[i]).Print();
        }
        Days days = new Days();
        IPrinter[] array2 = new IPrinter[4];
        array2[0] = (IPrinter)arr[0];
        array2[1] = (IPrinter)arr[1];
        array2[2] = (IPrinter)arr[2];
        array2[3] = days;
        for (int i = 0; i < 4; i++)
        {
            ((IPrinter)array2[i]).Print();
        }
    }
}



