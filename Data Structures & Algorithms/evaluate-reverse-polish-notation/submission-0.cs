public class Solution {
    public int EvalRPN(string[] tokens) {
        
        //stack - push number, if math pop two and do the expression, then push back onto stack repeat
        var mStack = new Stack<int>();
        foreach(string cur in tokens)
        {
            if(int.TryParse(cur, out int number))
            {
                mStack.Push(number);
            }else
            {
                int second = mStack.Pop();
                int first = mStack.Pop();

                mStack.Push( cur switch
                {
                    "+" => first + second,
                    "-" => first - second,
                    "*" => first * second,
                    "/" => first / second,
                    _ => 0
                });

            }
        }
        return mStack.Pop();
    }
}
