//HintName: G.IModelsClient.EstimatePricing.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Estimate cost<br/>
        /// Computes cost estimates using one of two methods:<br/>
        /// **1. Historical API Price** (`historical_api_price`):<br/>
        /// - Based on historical pricing per API call from past usage patterns<br/>
        /// - Takes `call_quantity` (number of API calls) per endpoint<br/>
        /// - Useful for estimating based on actual historical usage patterns<br/>
        /// - Example: "How much will 100 calls to flux/dev cost?"<br/>
        /// **2. Unit Price** (`unit_price`):<br/>
        /// - Based on unit price × expected billing units from pricing service<br/>
        /// - Takes `unit_quantity` (number of billing units like images/videos) per endpoint<br/>
        /// - Useful when you know the expected output quantity<br/>
        /// - Example: "How much will 50 images from flux/dev cost?"<br/>
        /// **Authentication:** Required. Users must provide a valid API key.<br/>
        /// Custom pricing or discounts may be applied based on account status.<br/>
        /// **Common Use Cases:**<br/>
        /// - Pre-calculate costs for batch operations<br/>
        /// - Display cost estimates in user interfaces<br/>
        /// - Budget planning and cost optimization<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EstimatePricingResponse> EstimatePricingAsync(

            global::G.OneOf<global::G.EstimatePricingRequestVariant1, global::G.EstimatePricingRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate cost<br/>
        /// Computes cost estimates using one of two methods:<br/>
        /// **1. Historical API Price** (`historical_api_price`):<br/>
        /// - Based on historical pricing per API call from past usage patterns<br/>
        /// - Takes `call_quantity` (number of API calls) per endpoint<br/>
        /// - Useful for estimating based on actual historical usage patterns<br/>
        /// - Example: "How much will 100 calls to flux/dev cost?"<br/>
        /// **2. Unit Price** (`unit_price`):<br/>
        /// - Based on unit price × expected billing units from pricing service<br/>
        /// - Takes `unit_quantity` (number of billing units like images/videos) per endpoint<br/>
        /// - Useful when you know the expected output quantity<br/>
        /// - Example: "How much will 50 images from flux/dev cost?"<br/>
        /// **Authentication:** Required. Users must provide a valid API key.<br/>
        /// Custom pricing or discounts may be applied based on account status.<br/>
        /// **Common Use Cases:**<br/>
        /// - Pre-calculate costs for batch operations<br/>
        /// - Display cost estimates in user interfaces<br/>
        /// - Budget planning and cost optimization<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EstimatePricingResponse> EstimatePricingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}