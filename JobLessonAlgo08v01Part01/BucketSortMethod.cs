public class BucketSortMethod
{
    public static List<int> BucketSort (ICollection<int> intCollection, int index)
    {
        List<int>[] noSortedList = new List<int>[index];
        List<int> sortedList = new List<int>(intCollection.Count);

        int minValue = Enumerable.Min(intCollection);
        int maxValue = Enumerable.Max(intCollection);
        int lenghtSearch = (maxValue - minValue) /index+1;
        for (int i=0; i < index; i++)
        {
            noSortedList[i] = new List<int>();
        }

        foreach (int intFromCollection in intCollection)
        {
            noSortedList[(intFromCollection-minValue)/lenghtSearch].Add(intFromCollection); 
        }
        foreach(var noSortedInt in noSortedList)
        {
            sortedList.AddRange(noSortedInt.OrderBy(x => x));
        }
        return sortedList;

    }
}



