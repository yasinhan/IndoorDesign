namespace IndoorDesign.backend.domain.material.repository;

public interface IMaterialTypeRepository
{
    void SaveMaterialType(MaterialType materialType);

    List<MaterialType> ListAllMaterialType();
}

public class MaterialTypeRepository : IMaterialTypeRepository
{
    public void SaveMaterialType(MaterialType materialType)
    {
        throw new NotImplementedException();
    }

    public List<MaterialType> ListAllMaterialType()
    {
        throw new NotImplementedException();
    }
}