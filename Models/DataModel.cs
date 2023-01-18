namespace mvcLab1.Models
{
    public class DataModel
    {
        public static List<Guest> guests = new List<Guest>()
        {
            new Guest{name="omar",email="omar@gmail.com",phone="01140038955",willAttend="True"},
            new Guest{name="eman",email="eman@gmail.com",phone="01113821936",willAttend="True"}
        };
        public static List <Guest> getAll()=>guests.ToList();
        public static void AddGuest(Guest guest)
        {
            guests.Add(guest);  
        }
    }
}
