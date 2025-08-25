namespace Todo.Core.Models
{
    public class TodoCreationModel
    {
        public int Id { get; set; }
        public string? Title { get; set; } = default;
        public string? Description { get; set; } = default;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public bool IsDone { get; set; } = false;
    }
}
