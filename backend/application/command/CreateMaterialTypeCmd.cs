namespace IndoorDesign.backend.application.command;

public class CreateMaterialTypeCmd(long? parentId, string code, string name);

public class UpdateMaterialTypeCmd(long id, long? parentId, string code, string name)
    : CreateMaterialTypeCmd(parentId, code, name);