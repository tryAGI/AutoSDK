//HintName: G.IModelPricingClient.GetModelPricing.g.cs
#nullable enable

namespace G
{
    public partial interface IModelPricingClient
    {
        /// <summary>
        /// Get Model Pricing<br/>
        /// Returns pricing configuration for a specific model.<br/>
        /// **Note:** Prices are in USD cents per token.<br/>
        /// ## Supported Providers<br/>
        /// openai, anthropic, google, azure-openai, bedrock, mistral-ai, cohere, <br/>
        /// together-ai, groq, deepseek, fireworks-ai, perplexity-ai, anyscale, <br/>
        /// deepinfra, cerebras, x-ai, and 25+ more.<br/>
        /// ## Example Response Fields<br/>
        /// | Field | Description | Unit |<br/>
        /// |-------|-------------|------|<br/>
        /// | `request_token.price` | Input token cost | cents/token |<br/>
        /// | `response_token.price` | Output token cost | cents/token |<br/>
        /// | `cache_write_input_token.price` | Cache write cost | cents/token |<br/>
        /// | `cache_read_input_token.price` | Cache read cost | cents/token |<br/>
        /// | `additional_units.*` | Provider-specific features | cents/unit |
        /// </summary>
        /// <param name="provider">
        /// Example: openai
        /// </param>
        /// <param name="model">
        /// Example: gpt-5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelPricingConfig> GetModelPricingAsync(
            string provider,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}