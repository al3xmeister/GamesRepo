namespace CodingChallenge.ReversingString;

public class StringUtilities
{
    public static string Reverse(string s)
    {
        if (!string.IsNullOrWhiteSpace(s))
        {
            char[] textAsArray = s.ToCharArray();
            Array.Reverse(textAsArray);
            var reversedString = new String(textAsArray);
            return reversedString;
        }
        else
        {
            return null;
        }
    }
}
