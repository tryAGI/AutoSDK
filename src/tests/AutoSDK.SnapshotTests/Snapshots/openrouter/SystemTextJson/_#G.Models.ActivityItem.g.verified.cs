//HintName: G.Models.ActivityItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityItem
    {
        /// <summary>
        /// Date of the activity (YYYY-MM-DD format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Model slug (e.g., "openai/gpt-4.1")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Model permaslug (e.g., "openai/gpt-4.1-2025-04-14")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Unique identifier for the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Name of the provider serving this endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Total cost in USD (OpenRouter credits spent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// BYOK inference cost in USD (external credits spent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_inference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageInference { get; set; }

        /// <summary>
        /// Number of requests made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Requests { get; set; }

        /// <summary>
        /// Total prompt tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// Total completion tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// Total reasoning tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityItem" /> class.
        /// </summary>
        /// <param name="date">
        /// Date of the activity (YYYY-MM-DD format)
        /// </param>
        /// <param name="model">
        /// Model slug (e.g., "openai/gpt-4.1")
        /// </param>
        /// <param name="modelPermaslug">
        /// Model permaslug (e.g., "openai/gpt-4.1-2025-04-14")
        /// </param>
        /// <param name="endpointId">
        /// Unique identifier for the endpoint
        /// </param>
        /// <param name="providerName">
        /// Name of the provider serving this endpoint
        /// </param>
        /// <param name="usage">
        /// Total cost in USD (OpenRouter credits spent)
        /// </param>
        /// <param name="byokUsageInference">
        /// BYOK inference cost in USD (external credits spent)
        /// </param>
        /// <param name="requests">
        /// Number of requests made
        /// </param>
        /// <param name="promptTokens">
        /// Total prompt tokens used
        /// </param>
        /// <param name="completionTokens">
        /// Total completion tokens generated
        /// </param>
        /// <param name="reasoningTokens">
        /// Total reasoning tokens used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityItem(
            string date,
            string model,
            string modelPermaslug,
            string endpointId,
            string providerName,
            double usage,
            double byokUsageInference,
            double requests,
            double promptTokens,
            double completionTokens,
            double reasoningTokens)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.Usage = usage;
            this.ByokUsageInference = byokUsageInference;
            this.Requests = requests;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityItem" /> class.
        /// </summary>
        public ActivityItem()
        {
        }
    }
}