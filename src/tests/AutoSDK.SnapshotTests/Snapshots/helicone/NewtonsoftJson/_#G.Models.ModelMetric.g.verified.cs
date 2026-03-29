//HintName: G.Models.ModelMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_prompt_token", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalPromptToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetric" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="totalRequests"></param>
        /// <param name="totalCompletionTokens"></param>
        /// <param name="totalPromptToken"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cost"></param>
        public ModelMetric(
            string model,
            double totalRequests,
            double totalCompletionTokens,
            double totalPromptToken,
            double totalTokens,
            double cost)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TotalRequests = totalRequests;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.TotalPromptToken = totalPromptToken;
            this.TotalTokens = totalTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetric" /> class.
        /// </summary>
        public ModelMetric()
        {
        }
    }
}