namespace Demos;

class XorUsage
{
    public int GetUniqueInt(int a, int b, int c)
    {
        return a ^= b ^= c;
    }

    public string XorString(string a, string b)
    {
        return "";
    }
}