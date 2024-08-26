namespace IndoorDesign.backend.domain.material;

public class MaterialQuote
{
    #region Field

    public int? QuoteId;

    public required int MaterialId { get; init; }
    
    public required int SupplierId { get; init; }
    
    public List<QuoteRule> Rules { get; private set; }

    #endregion

    #region Method

    public void AddRule(QuoteRule rule)
    {
        var exist = Rules.Find(item => item.MinQuantity == rule.MinQuantity);
        if (null != exist)
        {
            Rules.Remove(exist);
        }
        Rules.Add(rule);
    }

    public void RemoveRule(QuoteRule rule)
    {
        
    }

    #endregion
}