public class MyQueue {
    
    List<int> first, second;

    public MyQueue() {
        first = new List<int>();
        second = new List<int>();
    }
    
    public void Push(int x) {
        first.Add(x);
    }
    
    public int Pop() {
        int popOutput;
        if(second.Any()){
            popOutput = second.Last();
            second.RemoveAt(second.Count - 1);
            return popOutput;
        }
        
        int length = first.Count;
        for(int i = length - 1; i >= 1; i--){
            second.Add(first[i]);
            first.RemoveAt(i);
        }
        
        popOutput = first.Last();
        first.RemoveAt(first.Count - 1);
        return popOutput;
    }
    
    public int Peek() {
        if(second.Any()){
            return second.Last();
        }
        
        int length = first.Count;
        for(int i = length - 1; i >= 0; i--){
            second.Add(first[i]);
            first.RemoveAt(i);
        }
        
        return second.Last();
    }
    
    public bool Empty() {
        return first.Count == 0 && second.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */