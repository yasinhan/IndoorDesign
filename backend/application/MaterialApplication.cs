using IndoorDesign.backend.application.command;
using IndoorDesign.backend.application.dto;
using IndoorDesign.backend.domain.material.repository;

namespace IndoorDesign.backend.application;

public interface IMaterialTypeApplication
{
    void CreateMaterialType(CreateMaterialTypeCmd cmd);

    List<MaterialTypeDto> ListAllType();
}

public interface IMaterialApplication
{
    
}

public class MaterialTypeApplication(IMaterialTypeRepository materialTypeRepository) : IMaterialTypeApplication
{
    private IMaterialTypeRepository MaterialTypeRepository = materialTypeRepository;

    public void CreateMaterialType(CreateMaterialTypeCmd cmd)
    {
        throw new NotImplementedException();
    }

    public List<MaterialTypeDto> ListAllType()
    {
        throw new NotImplementedException();
    }
}