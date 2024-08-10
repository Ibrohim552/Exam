namespace Infro;

public class ClientManager<T>
{
    List<T> clients=new List<T>();

    public void Add(T client)
    {
        try
        {
            clients.Add(client);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public void Remove(T client)
    {
        try
        {
            var io = clients.Find(x => x.Id == client.Id);
            if (io!=null)
            {
                clients.Remove(io);
            }
            else
            {
                System.Console.WriteLine("Not found");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public void Update(T client)
    {
        try
        {
            var io = client.Find(x => x.Id == client.Id);
            if (io != null)
            {
                clients.Name = io.Name;
                clients.ContactInfo = io.ContactInfo;
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public List<T> GetAll()
    {
        try
        {
            return clients;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }
}