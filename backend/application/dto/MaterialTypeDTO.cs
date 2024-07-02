namespace IndoorDesign.backend.application.dto;

public class MaterialTypeDto
{
    public long Id { get; init; }
    public required string TypeCode { get; init; }
    public required string TypeName { get; init; }
    public int Level { get; init; }
    public List<MaterialTypeDto>? Children { get; init; }
}