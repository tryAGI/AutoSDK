//HintName: G.Models.ToolOutputOffloadingConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for offloading large tool outputs to artifacts.<br/>
    /// When tools produce outputs exceeding the size threshold, the output is stored<br/>
    /// as an artifact and replaced with a compact reference. The agent can then use<br/>
    /// artifact_read or artifact_grep to access the full content on demand.<br/>
    /// All fields are optional; omitted fields use model-inferred defaults.
    /// </summary>
    public sealed partial class ToolOutputOffloadingConfiguration
    {
        /// <summary>
        /// Whether tool output offloading is enabled. If not specified, defaults to true<br/>
        /// when the agent has artifact_read configured, false otherwise.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Percentage of the model's context window to use as the offloading threshold,<br/>
        /// estimated at 4 characters per token. This is a rough heuristic that varies<br/>
        /// across LLMs. The resulting byte threshold is clamped between min_threshold_bytes<br/>
        /// and max_threshold_bytes, so this percentage only has an effect when it produces<br/>
        /// a value lower than max_threshold_bytes.<br/>
        /// Default Value: 0.05<br/>
        /// Example: 0.05
        /// </summary>
        /// <example>0.05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_percentage")]
        public double? ContextPercentage { get; set; }

        /// <summary>
        /// Tool outputs above this size (in bytes) will always be offloaded. Acts as a<br/>
        /// ceiling on the context_percentage-derived threshold. For large-context models,<br/>
        /// max_threshold_bytes is typically the effective threshold since the<br/>
        /// context_percentage calculation exceeds it.<br/>
        /// Example: 32768
        /// </summary>
        /// <example>32768</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_threshold_bytes")]
        public long? MaxThresholdBytes { get; set; }

        /// <summary>
        /// Tool outputs below this size (in bytes) will never be offloaded. Acts as a<br/>
        /// floor on the context_percentage-derived threshold, ensuring small outputs are<br/>
        /// never offloaded even for models with small context windows.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_threshold_bytes")]
        public long? MinThresholdBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputOffloadingConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tool output offloading is enabled. If not specified, defaults to true<br/>
        /// when the agent has artifact_read configured, false otherwise.<br/>
        /// Example: true
        /// </param>
        /// <param name="contextPercentage">
        /// Percentage of the model's context window to use as the offloading threshold,<br/>
        /// estimated at 4 characters per token. This is a rough heuristic that varies<br/>
        /// across LLMs. The resulting byte threshold is clamped between min_threshold_bytes<br/>
        /// and max_threshold_bytes, so this percentage only has an effect when it produces<br/>
        /// a value lower than max_threshold_bytes.<br/>
        /// Default Value: 0.05<br/>
        /// Example: 0.05
        /// </param>
        /// <param name="maxThresholdBytes">
        /// Tool outputs above this size (in bytes) will always be offloaded. Acts as a<br/>
        /// ceiling on the context_percentage-derived threshold. For large-context models,<br/>
        /// max_threshold_bytes is typically the effective threshold since the<br/>
        /// context_percentage calculation exceeds it.<br/>
        /// Example: 32768
        /// </param>
        /// <param name="minThresholdBytes">
        /// Tool outputs below this size (in bytes) will never be offloaded. Acts as a<br/>
        /// floor on the context_percentage-derived threshold, ensuring small outputs are<br/>
        /// never offloaded even for models with small context windows.<br/>
        /// Example: 4096
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolOutputOffloadingConfiguration(
            bool? enabled,
            double? contextPercentage,
            long? maxThresholdBytes,
            long? minThresholdBytes)
        {
            this.Enabled = enabled;
            this.ContextPercentage = contextPercentage;
            this.MaxThresholdBytes = maxThresholdBytes;
            this.MinThresholdBytes = minThresholdBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputOffloadingConfiguration" /> class.
        /// </summary>
        public ToolOutputOffloadingConfiguration()
        {
        }
    }
}