using Library;
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

Archer robin = new Archer("Robin", "Villano", 3);
robin.Bow = new Bow();
robin.Helmet = new Helmet();

Knight garen = new Knight("Garen", "Villano", 1);
garen.Sword = new Sword();
garen.Shield = new Shield();
garen.Armor = new Armor();

Dwarf Grimble = new Dwarf("Grimble", "Villano", 2);
Grimble.Axe = new Axe();
Grimble.Helmet = new Helmet();

Wizard merlin = new Wizard("Merlin", "Villano", 2);
merlin.Staff = new Staff();
merlin.SpellsBook = book;


List<ICharacter> listaCharacters = [];
listaCharacters.Add(gandalf);
listaCharacters.Add(gimli);
listaCharacters.Add(MegaKnight);
//listaCharacters.Add(apollo);
//listaCharacters.Add(robin);
listaCharacters.Add(garen);
//listaCharacters.Add(Grimble);
listaCharacters.Add(merlin);

Encounter encuentro = new Encounter(listaCharacters);
encuentro.DoEncounter();

