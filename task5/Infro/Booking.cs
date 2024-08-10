namespace Infro;

public class Booking
{
    public Room Room { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public Booking(Room room, DateTime checkInDate, DateTime checkOutDate)
    {
        Room = room;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
    }
}