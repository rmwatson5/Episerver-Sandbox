using EPiServer.Core;

namespace AlloyEpiserverSite.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
