//HintName: G.Models.UpdateGenerationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGenerationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionStartTime")]
        public global::System.DateTime? CompletionStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelParameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IngestionUsageJsonConverter))]
        public global::G.IngestionUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptName")]
        public string? PromptName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDetails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageDetailsJsonConverter))]
        public global::G.UsageDetails? UsageDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDetails")]
        public global::System.Collections.Generic.Dictionary<string, double>? CostDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public int? PromptVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGenerationBody" /> class.
        /// </summary>
        /// <param name="completionStartTime"></param>
        /// <param name="model"></param>
        /// <param name="modelParameters"></param>
        /// <param name="usage"></param>
        /// <param name="promptName"></param>
        /// <param name="usageDetails"></param>
        /// <param name="costDetails"></param>
        /// <param name="promptVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGenerationBody(
            global::System.DateTime? completionStartTime,
            string? model,
            object? modelParameters,
            global::G.IngestionUsage? usage,
            string? promptName,
            global::G.UsageDetails? usageDetails,
            global::System.Collections.Generic.Dictionary<string, double>? costDetails,
            int? promptVersion)
        {
            this.CompletionStartTime = completionStartTime;
            this.Model = model;
            this.ModelParameters = modelParameters;
            this.Usage = usage;
            this.PromptName = promptName;
            this.UsageDetails = usageDetails;
            this.CostDetails = costDetails;
            this.PromptVersion = promptVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGenerationBody" /> class.
        /// </summary>
        public UpdateGenerationBody()
        {
        }
    }
}