public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>>anagramMap = new Dictionary<string,List<string>>();
        for(int i = 0; i < strs.Length; i++){
            int[] charCount = new int[26];
            foreach(char c in strs[i]){
                charCount[c - 'a']++;
            }
            string key = string.Join(",",charCount);
           if(!anagramMap.ContainsKey(key)){
            anagramMap.Add(key, new List<string>());
           }

           anagramMap[key].Add(strs[i]);

        }
        return new List<List<string>>(anagramMap.Values);
    }
}
