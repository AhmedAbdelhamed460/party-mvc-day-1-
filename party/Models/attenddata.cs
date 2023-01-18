namespace party.Models
{
    public class attenddata
    {
        public static List<Attendees> guests = new List<Attendees>()
        {
            new Attendees{name="ali",email="ali.com",phone="0254545465",willAttend="True"},
            new Attendees{name="sayd",email="sayd@gmail.com",phone="476546",willAttend="True"},
            new Attendees{name="mido",email="mido@gmail.com",phone="08987878",willAttend="True"}
        };
        public static List<Attendees> getAll() => Attendees.ToList();
        public static void AddGuest(Attendees attendees)
        {
            Attendees.Add(attendees);
        }

    }
}
