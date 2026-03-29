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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPromptToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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