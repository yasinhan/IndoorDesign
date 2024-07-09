namespace IndoorDesign.backend.domain.material;

public class MaterialType(int? typeId, string typeName, string typeCode, int parentId)
{
    #region Field

    public int? TypeId = typeId;

    public required string TypeName { get; init; } = typeName;

    public required string TypeCode { get; init; } = typeCode;

    public int ParentId { get; private set; } = parentId;

    public List<MaterialType>? Childern { get; private set; }
    
    #endregion`

    #region Method

    public bool Equals(MaterialType other)
    {
        return TypeName == other.TypeName && TypeCode == other.TypeCode;
    }

    public void WithChildren(List<MaterialType> children)
    {
        Childern = children;
    }

    #endregion
    
}
    