namespace CoreData
{
    using System;

    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string IPAddress { get; set; }
    }
}