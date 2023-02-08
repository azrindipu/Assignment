namespace Assignment.util;

public class Util
{
    public static int GetRand(int lowerBound, int upperBound)
    {
        Random random = new Random();
        return random.Next(lowerBound, upperBound); ;
    }
}