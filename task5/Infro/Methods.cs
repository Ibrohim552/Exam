namespace Infro;

public class BookingMethod
{
    private List<Booking> _bookings=new List<Booking>();

    public bool AddBooking(Room room, DateTime checkInDate, DateTime checkOutDate)
    {
        if (IsRoomAvailable(room, checkInDate, checkOutDate))
        {
            Booking newBooking = new Booking(room, checkInDate, checkOutDate);
            _bookings.Add(newBooking);
            return true;
        }
        return false;
    }

    
}

}