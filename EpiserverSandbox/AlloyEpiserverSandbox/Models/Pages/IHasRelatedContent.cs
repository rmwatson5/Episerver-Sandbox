using EPiServer.Core;

namespace AlloyEpiserverSandbox.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
