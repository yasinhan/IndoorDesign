using System.ComponentModel.DataAnnotations;

namespace IndoorDesign.Data;

public class MaterialTypePo
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int ParentId { get; set; }
    
}

public class MaterialPo
{
    [Key]
    public int Id { get; set; }
}