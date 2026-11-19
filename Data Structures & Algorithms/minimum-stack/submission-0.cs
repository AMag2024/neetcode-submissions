public class MinStack {

    private Node? head = null;

    public MinStack() {
    }
    
    public void Push(int val) {
        if(head == null || val <= head.Min)
        {
            head = new Node(val, head, val);
        }else
        {
            head = new  Node(head.Min, head, val);
        }
    }
    
    public void Pop() {
        head = head.Prev;
    }
    
    public int Top() {
        return head.Value;
    }
    
    public int GetMin() {
        return head.Min;
    }

    private class Node
    {
        public int Min {get; init;}
        public Node? Prev {get; init;}
        public int Value {get; set;}

        public Node(int min, Node? prev, int value)
        {
            Min = min;
            Prev = prev;
            Value = value;
        }

    }
}
