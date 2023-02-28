namespace QA2_TurarkulovYrys.Entities
{
    public class Order: BaseEntity, ICloneable
    {
        public DateTime OrderDate { get; set; }
        public uint ClientID { get; set; }
        public string Description { get; set; }
        public float OrderPrice { get; set; }
        public DateTime? CloseDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
