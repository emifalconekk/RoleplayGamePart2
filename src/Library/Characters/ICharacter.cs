namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; }
    int Health { get; }
    int AttackValue { get; }

    int DefenseValue { get; }
    void AddItem(IItem item);
    void RemoveItem (IItem item);
    void ReceiveAttack(int power);
    void Cure();
}
