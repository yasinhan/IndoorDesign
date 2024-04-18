namespace IndoorDesign.backend.application.dto;

public class MaterialTypeDto
{
    public long Id { get; set; }
    public string? TypeCode { get; set; }
    public string? TypeName { get; set; }
    public int Level { get; set; }
    public List<MaterialTypeDto>? Children { get; set; }
}