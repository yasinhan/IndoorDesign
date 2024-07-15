using IndoorDesign.backend.application.command;
using IndoorDesign.backend.application.dto;
using IndoorDesign.backend.domain.material;
using IndoorDesign.backend.domain.material.repository;

namespace IndoorDesign.backend.application;

public interface IMaterialTypeApplication
{
    void CreateMaterialType(CreateMaterialTypeCmd cmd);

    List<MaterialTypeDto> ListAllRootType();
    
    List<MaterialTypeDto> ListChildrenType(int parentId);
}

public interface IMaterialApplication
{
    
}

public class MaterialTypeApplication(IMaterialTypeRepository materialTypeRepository) : IMaterialTypeApplication
{
    private IMaterialTypeRepository MaterialTypeRepository = materialTypeRepository;

    public void CreateMaterialType(CreateMaterialTypeCmd cmd)
    {
        if (cmd.ParentId > 0) 
        {
            var parent = materialTypeRepository.FindMaterialType(cmd.ParentId) ?? throw new ArgumentException("父类型不存在");
        }

        var type = new MaterialType(null, cmd.Code, cmd.Name, cmd.ParentId)
        {
            TypeCode = cmd.Code,
            TypeName = cmd.Name,
        };
        materialTypeRepository.SaveMaterialType(type);
    }

    public List<MaterialTypeDto> ListAllRootType()
    {
        var roots = materialTypeRepository.ListRootMaterialType();
        return roots.Select(ConvertToDto).ToList();
    }

    public List<MaterialTypeDto> ListChildrenType(int parentId)
    {
        var children = MaterialTypeRepository.FindChildren(parentId);
        return children.Select(ConvertToDto).ToList();
    }

    private MaterialTypeDto ConvertToDto(MaterialType materialType)
    {
        return new MaterialTypeDto((int)materialType.TypeId!, materialType.TypeCode, materialType.TypeName,
            materialType.ParentId)
        {
            TypeCode = materialType.TypeCode,
            TypeName = materialType.TypeName
        };
    }
}