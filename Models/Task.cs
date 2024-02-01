namespace TaskApi.Models
{
    public class Task
    {
        // Add properties
        // Id, Name, Created By, Created On, Description
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Description { get; set; }
    }
}
