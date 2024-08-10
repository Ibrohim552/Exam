namespace Infro;

public class EventsMethod
{
    List<Event> events = new List<Event>();
   
    public void AddEvent(Event newEvent)
    {
        try
        {
            var eventss = events.Find(x => x.Title == newEvent.Title);
            if (eventss == null)
            {
                events.Add(newEvent);
            }

            else
            {
                Console.WriteLine("This event is already exist");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public void RemoveEvent(string title)
    {
        try
        {
            var eventss = events.Find(x => x.Title == title);
            if (eventss != null)
            {
                events.Remove(eventss);
            }
            else
            {
                Console.WriteLine("This event does not exist");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
    }

    public List<Event> SearchEventsByDay(DateTime date)
    {
        var eventsOnDate = events.FindAll(x => x.StartTime.Day == date.Day);

        if (eventsOnDate.Count > 0)
        {
            Console.WriteLine("Events on {0:dd/MM/yyyy}:", date);
            foreach (var e in eventsOnDate)
            {
                Console.WriteLine(e.Title);
            }
        }
        else
        {
            Console.WriteLine("No events found on {0:dd/MM/yyyy}", date);
        }
    }
    
}