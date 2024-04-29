namespace Domain;

public class Webinar : Entity
{
    public Webinar(Guid id, string name, DateTime scheduledOn) : base(id) 
    {
        Name = name;
        ScheduledOn = scheduledOn;
    }

    public string Name { get; private set;}
    public DateTime ScheduledOn { get; private set;}
}