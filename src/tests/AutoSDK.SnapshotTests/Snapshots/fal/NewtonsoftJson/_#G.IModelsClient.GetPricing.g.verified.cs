//HintName: G.IModelsClient.GetPricing.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Pricing<br/>
        /// Returns unit pricing for requested endpoint IDs. Most models use<br/>
        /// **output-based** pricing (e.g., per image/video with proportional<br/>
        /// adjustments for resolution/length). Some models use **GPU-based** pricing<br/>
        /// depending on architecture. Values are expressed per model's billing unit<br/>
        /// in a given currency.<br/>
        /// **Authentication:** Required. Users must provide a valid API key. <br/>
        /// Custom pricing or discounts may be applied based on account status.<br/>
        /// **Common Use Cases:**<br/>
        /// - Display pricing in user interfaces<br/>
        /// - Compare pricing across different models<br/>
        /// - Build cost estimation tools<br/>
        /// - Check current billing rates<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPricingResponse> GetPricingAsync(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}