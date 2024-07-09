using IndoorDesign.Data;

namespace IndoorDesign.backend.domain.material.repository;

public interface IMaterialTypeRepository
{
    void SaveMaterialType(MaterialType materialType);

    List<MaterialType> ListRootMaterialType();
    
    List<MaterialType> FindChildren(int typeId);
    
    MaterialType? FindMaterialType(int typeId);
}

public class MaterialTypeRepository(SqliteDbContext dbContext) : IMaterialTypeRepository
{
    private readonly SqliteDbContext _dbContext = dbContext;

    public void SaveMaterialType(MaterialType materialType)
    {
        var po = MaterialConvertor.ConvertToMaterialTypePo(materialType);
        _dbContext.MaterialType.Add(po);
        _dbContext.SaveChanges();
    }

    public List<MaterialType> ListRootMaterialType()
    {
        return _dbContext.MaterialType
            .Where(it => it.ParentId == 0)
            .Select(p => MaterialConvertor.ComposeMaterialType(p))
            .ToList();
    }

    public List<MaterialType> FindChildren(int typeId)
    {
        return _dbContext.MaterialType
            .Where(it => it.ParentId == typeId)
            .Select(p => MaterialConvertor.ComposeMaterialType(p))
            .ToList();
    }

    public MaterialType? FindMaterialType(int typeId)
    {
        return _dbContext.MaterialType
            .Where(it => it.Id == typeId)
            .Select(p => MaterialConvertor.ComposeMaterialType(p))
            .FirstOrDefault();
    }
}

public class MaterialConvertor
{
    public static MaterialType ComposeMaterialType(MaterialTypePo po)
    {
        return new MaterialType(po.Id, po.Name, po.Code, po.ParentId)
        {
            TypeCode = po.Code,
            TypeName = po.Name
        };
    }

    public static MaterialTypePo ConvertToMaterialTypePo(MaterialType materialType)
    {
        return new MaterialTypePo
        {
            Code = materialType.TypeCode,
            Name = materialType.TypeName,
            ParentId = materialType.ParentId
        };
    }
}