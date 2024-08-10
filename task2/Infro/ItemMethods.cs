namespace Infro;

public class Inventory<T> where T :Item
{
    private List<Item> items = new List<Item>();

    public void Add(T item)
    {
        try
        {
            var io=items.FindAll(x=>x.Name==item.Name);
            if (io.Count==0)
            {
                items.Add(item);
            }

            Console.WriteLine("Item already exists");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Remove(T item)
    {
        try
        {
            var io = items.Find(x => x.Name == item.Name);
            if (io != null)
            {
                items.Remove(io);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Item> GetItemsByCayegory(string category)
    {
        try
        {
            var io = items.FindAll(x => x.Category == category);
            if (io != null)
            {
                return io;
            }

            Console.WriteLine("Not found this category");
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Item> GetAllitems()
    {
        return items;
    }

}