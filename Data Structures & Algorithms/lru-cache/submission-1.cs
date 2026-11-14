public class LRUCache {

    private Dictionary<int,LinkedListNode<KeyValuePair<int,int>>> mLRUCache;
    private int capacity;
    private LinkedList<KeyValuePair<int,int>> list = new();

    public LRUCache(int capacity) {
        mLRUCache = new Dictionary<int,LinkedListNode<KeyValuePair<int,int>>>(capacity);
        this.capacity = capacity;
    }
    
    public int Get(int key) {

        if(mLRUCache.TryGetValue(key, out LinkedListNode<KeyValuePair<int,int>> node)){
        this.Put(key, node.Value.Value);
        return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        //check if the key is in the cache, if so move it to the head
        var newNode = new LinkedListNode<KeyValuePair<int,int>>(
            new KeyValuePair<int,int>(key,value)
        );
        if(mLRUCache.TryGetValue(key, out LinkedListNode<KeyValuePair<int,int>> cur))
        {
            list.Remove(cur);
            list.AddFirst(newNode);
            mLRUCache[key] = newNode;
        }else{
        //if not, check if linked list is at capacity
            if(list.Count == capacity)
            {
        //if it is remove the tail and remove the old key in the map
                int lastKey = list.Last.Value.Key;
                list.RemoveLast();
                mLRUCache.Remove(lastKey);
            }
        //add the new key and the new node
            list.AddFirst(newNode);
            mLRUCache[key] = newNode;
        }
        
    }
}
