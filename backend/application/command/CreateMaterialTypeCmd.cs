namespace IndoorDesign.backend.application.command;

public class CreateMaterialTypeCmd(int parentId, string code, string name)
{
    public string Code { get; set; } = code;
    public string Name { get; set; } = name;
    public int ParentId { get; set; } = parentId;
}

public class UpdateMaterialTypeCmd(int id, int parentId, string code, string name)
    : CreateMaterialTypeCmd(parentId, code, name)
{
    public int Id { get; set; } = id;
}