public class MyHashMap 
{
    Dictionary<int,int> dict1; 

    public MyHashMap() 
    {
       dict1 = new Dictionary<int,int>();    
    }
    
    public void Put(int key, int value) 
    {
        
            dict1[key] = value;
           
    }
    
    public int Get(int key) 
    {
        if(dict1.ContainsKey(key))
        {
            return dict1[key];
        }
        return -1;    
    }
    
    public void Remove(int key) 
    {
        dict1.Remove(key);    
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */