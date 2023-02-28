namespace QA2_TurarkulovYrys.Entities
{
    public class Client: BaseEntity, ICloneable
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNum { get; set; }
        public int OrderAmount { get; set; }
        public DateTime? DateAdd { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
