namespace DTO
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Picture { get; set; }
        public DateTime? PositiveAnswerDate { get; set; }
        public DateTime? RecoveryDate { get; set; }

    }
}