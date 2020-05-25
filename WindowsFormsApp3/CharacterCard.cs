using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    
    class CharacterCard: Card
    {
        public int HP { get; set;}
        public int Damage { get; set; }
        public int Cost { get; set; }
        public CharacterCard(CardCharacter character, CardLandscape landscape, int hp, int damage, int cost):base(character, landscape)
        {
            HP = hp;
            Damage = damage;
            Cost = cost;
        }
    }
}
