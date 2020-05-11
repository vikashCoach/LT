public class Solution {
   
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result =new List<IList<string>>();
        var dictionary= new Dictionary<string,List<string>>();
        foreach(var input in strs)
        {
           var currentWordKey =input.ToCharArray();
            Array.Sort(currentWordKey);
            var newString = new string(currentWordKey);
            if(!dictionary.ContainsKey(newString.ToString()))
            {
                dictionary.Add(newString,new List<string>(){input});
            }
            else
            {
                var existingWords= dictionary[newString];
                existingWords.Add(input);
                dictionary[newString] = existingWords;
            }
            
        }
        foreach(var values in dictionary.Keys){
           
           var allValues= dictionary[values];
          result.Add(allValues);
         //   result.Add(values);
        }

        
        return result;
    }
}
