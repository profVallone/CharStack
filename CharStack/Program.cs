using CharStack;
namespace CharStack;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string s = "[()(())]"; 
        Console.WriteLine(checkParentesis(s));
    }
    public static bool checkParentesis(string s)
    {
        CharStack cs = new CharStack(s.Length);
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            try
            {
                switch (c)
                {
                    case '[':
                        if (cs.isEmpty() || cs.getElem() != '(')
                            cs.push(c);
                        else 
                            return false;
                        break;
                    case '(':
                        cs.push(c);
                        break;
                    case ')':
                        if (cs.getElem() == '(')
                            cs.pop();
                        else
                            return false;
                        break;
                    case ']':
                        if (cs.getElem() == '[')
                            cs.pop();
                        else
                            return false;
                        break;

                }
            }catch(Exception e)
            {
                return false;
            }
        }
        if (cs.isEmpty())
            return true;
        return false;
    }
}