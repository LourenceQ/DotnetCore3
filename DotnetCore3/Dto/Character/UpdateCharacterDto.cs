using DotnetCore3.Models;

namespace DotnetCore3.Dto.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Ecneruol";
        public int HitPoints { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Mage;
    }
}