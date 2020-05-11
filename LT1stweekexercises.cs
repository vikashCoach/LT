public class Solution {
    public int CountElements(int[] arr) {
        Array.Sort(arr);
        var totalCounts= 0;
        var count =arr.Count()-1;
        for(int i =0;i<count;)
        {
            int j=i;
            int index=1;
            while(j<count-1 && arr[i]==arr[j+1])//to handle dupes
            {
                j++;
                i++;
                index++;
                
            }
            if(i < count && arr[i]+1 ==arr[i+1])
            {
                totalCounts+=index;
            }
            i++;
        
        }
        return totalCounts;
    }
}
