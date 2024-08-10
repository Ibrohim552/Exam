namespace Infro;

public class Item
{
    public string Name { get; set; }
    public string Category { get; set; }

    public enum Type
    {
        HomeItem,
        WorkItem,
        OfficeItem,
    }
}
