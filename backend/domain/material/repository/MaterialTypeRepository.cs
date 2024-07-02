namespace IndoorDesign.backend.domain.material.repository;

public interface IMaterialTypeRepository
{
    void SaveMaterialType(MaterialType materialType);

    List<MaterialType> ListAllMaterialType();
}