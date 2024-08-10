namespace Infro;

public class Room
{
    public enum TypeOfRoom
    {
        Single,
        Double,
        Suite
    }

    public class Room
    {
        public int RoomNumber { get; set; }
        public TypeOfRoom RoomType { get; set; }

        public Room(int roomNumber, TypeOfRoom roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
        }
    
}
