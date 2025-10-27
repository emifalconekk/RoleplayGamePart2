using Ucu.Poo.RoleplayGame;

namespace Library;

public class Encounter
{
    private List<ICharacter> listCharacters;

    public Encounter(List<ICharacter> listcharacters)
    {
        this.listCharacters = listcharacters;
    }


    public void DoEncounter()
    {
        List<ICharacter> villains = [];
        List<ICharacter> heroes = [];
        foreach (ICharacter c in this.listCharacters)
        {
            if (c.Role == "Villano")
            {
                villains.Add(c); 
            }
            if (c.Role == "Heroe")
            {
                heroes.Add(c); 
            }
        }
        
        EncounterLogistic(villains, heroes);
        
    }

    private void EncounterLogistic(List<ICharacter> villains,  List<ICharacter> heroes)
    {
        // Los villanos atacan a los heroes
        int battleCounter = 0;
        foreach (ICharacter v in villains)
        {
            heroes[battleCounter].ReceiveAttack(v.AttackValue);
            if (heroes[battleCounter].Health <= 0)
            {
                heroes.Remove(heroes[battleCounter]);
            }
            battleCounter++;
            if (battleCounter == heroes.Count())
            {
                battleCounter = 0;
            }
        }
        
        
        // Los heroes sobrevivientes atacan a los villanos
        foreach (ICharacter h in heroes)
        {
            foreach (ICharacter v in villains.ToList())
            { 
                v.ReceiveAttack(h.AttackValue);
                if (v.Health <= 0)
                {
                    villains.Remove(v);
                    h.VP += v.VP;
                    if (h.VP >= 5)
                    {
                        h.Cure();
                        h.VP -= 5; 
                    } 
                }
            } 
        }

        if (heroes.Count() > 0)
        {
            if (villains.Count() > 0)
            {
                this.EncounterLogistic(villains, heroes);
            }
            else
            {
                Console.WriteLine("Los heroes han ganado");
            }
        }
        else
        {
            Console.WriteLine("Los villanos han ganado");
        }
    }
}