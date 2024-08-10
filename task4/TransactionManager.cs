namespace Infro;

public class TransactionManager
{
    List<Transaction> transactions = new List<Transaction>();
    
    public void AddTransaction(Transaction newTransaction)
    {
        try
        {
            transactions.Add(newTransaction);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public List<Transaction> SearchBy(DateTime Year)
    {try
        {

            var io = transaction.Find(x => x.Year == Year);
            if (io != null)
            {
                return io;
            }

            return null;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }
    
}