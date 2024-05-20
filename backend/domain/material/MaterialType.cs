namespace IndoorDesign.backend.domain.material;

public class MaterialType
{
    #region Field

    public long TypeId;

    public required string TypeName;

    #endregion

    #region Method

    public bool equals(MaterialType other)
    {
        return this.TypeName == other.TypeName;
    }

    #endregion
}
    