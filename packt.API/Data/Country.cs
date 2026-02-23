namespace packt.API.Data;

public class Country
{
    public string Id { get; set; }
    public string Name { get; set; }

    public string ShortName { get; set; }

    public virtual IList<Hotel> Hotels { get; set; }
}