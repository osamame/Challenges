public class DuplicateIdentifier<T> where T : IEquatable<T>
{
    private readonly List<T> collectionA;

    public DuplicateIdentifier(List<T> collectionA)
    {
        this.collectionA = collectionA;
    }

    public void IdentifyDuplicates(List<T> collectionS)
    {
        foreach (var item in collectionS)
        {
            bool isDuplicate = collectionA.Contains(item);
            Console.WriteLine($"{item}:{isDuplicate}");
        }
    }
}