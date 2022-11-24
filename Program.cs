namespace övning;
class Program
{
    static void Main()
    {   

        var mobile = new Mobile ();
        var mobile1 = new Mobile ();

        Console.WriteLine(@"Mobile Information:
        UserId: {0}
        FullName: {1}
        MobileNumber: {2}", mobile.UserId, mobile.FullName, mobile.MobileNumber);
    }
}
