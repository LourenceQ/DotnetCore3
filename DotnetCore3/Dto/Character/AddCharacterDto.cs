using DotnetCore3.Models;

namespace DotnetCore3.Dto.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Ecneruol";
        public int Hitpoints { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Mage;
    }
}