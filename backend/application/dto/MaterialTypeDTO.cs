namespace IndoorDesign.backend.application.dto;

public class MaterialTypeDto(int id, string typeCode, string typeName, int parentId)
{
    public int Id { get; init; } = id;
    public required string TypeCode { get; init; } = typeCode;
    public required string TypeName { get; init; } = typeName;
    public int ParentId { get; init; } = parentId;
    public List<MaterialTypeDto>? Children { get; init; }
}