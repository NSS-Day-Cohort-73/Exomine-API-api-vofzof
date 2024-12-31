namespace ExomineApi.Modals;
public class Governor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool ActiveStatus { get; set; }
    public int ColonyId { get; set; }
}