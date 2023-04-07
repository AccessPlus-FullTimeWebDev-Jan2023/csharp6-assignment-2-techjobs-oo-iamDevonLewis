namespace CodingEvent.Models
{
    public class Event
    {

        public int Id { get; set; }
        static private int nextId = 1;
        public string Name { get; set; }
        public string Descripton { get; set; }

        public Event(string name, string descripton)
        {
            Name = name;
            Descripton = descripton;
            Id = nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

 

    
    
}
