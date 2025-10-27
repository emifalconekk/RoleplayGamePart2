using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new Spell[]{ new Spell() };

Wizard gandalf = new Wizard("Gandalf", "Heroe");
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;

Dwarf gimli = new Dwarf("Gimli", "Heroe");
gimli.Axe = new Axe();
gimli.Helmet = new Helmet();
gimli.Shield = new Shield();

Knight MegaKnight = new Knight("MegaKnight", "Heroe");
MegaKnight.Sword = new Sword();
MegaKnight.Armor= new Armor();
MegaKnight.Shield = new Shield();

Archer apollo = new Archer("Apollo", "Heroe");
apollo.Bow = new Bow();
apollo.Helmet = new Helmet();

Archer robin = new Archer("Robin", "Villano");
robin.Bow = new Bow();
robin.Helmet = new Helmet();

Knight garen = new Knight("Garen", "Villano");
garen.Sword = new Sword();
garen.Shield = new Shield();
garen.Armor = new Armor();

Dwarf Grimble = new Dwarf("Grimble", "Villano");
Grimble.Axe = new Axe();

Wizard merlin = new Wizard("Merlin", "Villano");
merlin.Staff = new Staff();
merlin.SpellsBook = book;


Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

