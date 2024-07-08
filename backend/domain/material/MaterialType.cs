namespace IndoorDesign.backend.domain.material;

public class MaterialType(long? typeId, string typeName, string typeCode, long parentId)
{
    #region Field

    public long? TypeId = typeId;

    public required string TypeName { get; init; } = typeName;

    public required string TypeCode { get; init; } = typeCode;

    public long ParentId { get; private set; } = parentId;

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
    