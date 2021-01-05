namespace Udemy_NetCore.Dtos.Fight
{
    public class AttackResultDto
    {
        public string Attacker { get; set; }   // name
        public string Opponent { get; set; }   // name
        public int AttackerHP { get; set; }    // hitpoints
        public int OpponentHP { get; set; }    // hitpoints
        public int Damage { get; set; }
    }
}