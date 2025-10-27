namespace Ucu.Poo.RoleplayGame;

public class Dwarf : ICharacter
{
    private int health = 100;

    private List<IItem> items = new List<IItem>();

    public Dwarf(string name, string role, int vp = 0)
    {
        this.Name = name;
        this.Role = role;
        this.VP = vp;
        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }

    public string Name { get; set; }

    public string Role { get; }
    
    public int VP { get; set; }
    
    
    public Axe Axe { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IAttack)
                {
                    value += (item as IAttack).AttackValue;
                }
            }

            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IDefense)
                {
                    value += (item as IDefense).DefenseValue;
                }
            }

            return value;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
        else
        {
            this.health -= 1;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }

    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }
}
