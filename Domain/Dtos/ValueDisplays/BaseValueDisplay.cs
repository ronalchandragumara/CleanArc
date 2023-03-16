namespace Domain.Dtos.ValueDisplays
{
    public class BaseValueDisplay
    {
        public string Display { get; set; } = string.Empty;
        public int? SortView { get; set; }
        public string? Remarks { get; set; }
        public string? Group { get; set; }
    }
}
