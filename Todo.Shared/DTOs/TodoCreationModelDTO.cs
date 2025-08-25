namespace Todo.Shared.DTOs
{
    public class TodoCreationModelDTO
    {
        public string? Title { get; set; } = default;
        public string? Description { get; set; } = default;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
