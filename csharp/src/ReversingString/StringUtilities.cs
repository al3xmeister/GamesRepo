namespace CodingChallenge.ReversingString;

public class StringUtilities
{
    public static string Reverse(string s)
    {
        if (!string.IsNullOrWhiteSpace(s))
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        else
        {
            return null;
        }
    }
}
