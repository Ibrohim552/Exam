using Infro;

var EventList=new EventsMethod();

var Event1 = new Event();
Event1.Title="Event";
Event1.Description="Description";
Event1.StartTime=new DateTime(2005,10,14);
Event1.EndTime=new DateTime(2005,10,20);
EventList.AddEvent(Event1);

var Event2 = new Event();
Event2.Title="Event 2";
Event2.Description="Description 2";
Event2.StartTime=new DateTime(15);
Event2.EndTime=new DateTime(14);
EventList.AddEvent(Event2);

EventList.RemoveEvent("Event");
EventList.SearchEventsByDay(new DateTime(25));
