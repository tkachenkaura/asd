namespace DataStructuresLib.Interfaces
{
    public interface IList : ICollection
    {
        object this[int index] { get; set; }
        void Insert(int index, object item);
        void RemoveAt(int index);
        int IndexOf(object item);
    }
}
