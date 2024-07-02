using IndoorDesign.backend.application.command;
using IndoorDesign.backend.application.dto;

namespace IndoorDesign.backend.application;

public interface IMaterialTypeApplication
{
    void CreateMaterialType(CreateMaterialTypeCmd cmd);

    List<MaterialTypeDto> ListAllType();
}

public interface IMaterialApplication
{
    
}