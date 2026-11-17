public class Solution {

   public Dictionary<char,char> pairs = new Dictionary<char,char>
                            {
                                {'{','}'},
                                {'[',']'},
                                {'(',')'}
                            };

    public bool IsValid(string s) {
        
    var mStack = new Stack<char>();

    foreach(char cur in s)
    {

        if(pairs.TryGetValue(cur, out char close))
        {
           mStack.Push(close);
        }else
        {
           if(mStack.Count == 0 || mStack.Pop() != cur)
           {
            return false;
           }
        }

    }

    return mStack.Count == 0;

    }
}
