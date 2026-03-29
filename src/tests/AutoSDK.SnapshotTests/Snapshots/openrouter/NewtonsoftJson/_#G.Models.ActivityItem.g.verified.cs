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
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// Model slug (e.g., "openai/gpt-4.1")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Model permaslug (e.g., "openai/gpt-4.1-2025-04-14")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_permaslug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelPermaslug { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Name of the provider serving this endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// Total cost in USD (OpenRouter credits spent)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public double Usage { get; set; } = default!;

        /// <summary>
        /// BYOK inference cost in USD (external credits spent)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_usage_inference", Required = global::Newtonsoft.Json.Required.Always)]
        public double ByokUsageInference { get; set; } = default!;

        /// <summary>
        /// Number of requests made
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double Requests { get; set; } = default!;

        /// <summary>
        /// Total prompt tokens used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// Total completion tokens generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Total reasoning tokens used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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