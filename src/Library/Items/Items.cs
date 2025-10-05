namespace Ucu.Poo.RoleplayGame;

public abstract class Item
{
    public string Name { get; set; }
    public bool IsMagical { get; set; }

    protected Item(string name, bool isMagical = false)
    {
        Name = name;
        IsMagical = isMagical;
    }
}