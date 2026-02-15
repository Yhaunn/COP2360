using System.Diagnostics;

public class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny(
      string name,
      bool likesCarrots = false,
      bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
    public void Output()
    {
        string message = Name + " is a bunny that does ";

        if (!LikesCarrots)
        {
            message += "not ";
        };

        message += "like carrots and also does ";

        if (!LikesHumans)
        {
            message += "not ";
        };

        message += "like humans";

        Console.WriteLine(message);
    }
}
public class aProgram
{ 
    static void Main()
    {
        List<bool> list = new List<bool>();

        Console.WriteLine("Name your new bunny");
        string? desiredName = Console.ReadLine();

        if (desiredName == null)
        {
            desiredName = "Just a bunny";
        }

        Console.WriteLine("Does your bunny like carrots? yes/no");
        string? response = Console.ReadLine();

        Debug.Assert(response != null, "response must not be null");

        bool likesCarrots;

        if (response == "yes" || response == "Yes")
        {
            likesCarrots = true;
        }
        else
        {
            likesCarrots = false;
        }

        Console.WriteLine("Does your bunny like humams?");
        string? response2 = Console.ReadLine();

        Debug.Assert(response2 != null, "response must not be null");

        bool likesHumans;

        if (response2 == "yes" || response2 == "Yes")
        {
            likesHumans = true;
        }
        else
        {
            likesHumans = false;
        }

        Bunny newBunny = new Bunny(desiredName, likesCarrots, likesHumans);
        newBunny.Output();
    }
}