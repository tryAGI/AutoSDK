//HintName: G.Models.PromptOptimizationJobCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EPromptOptimizationAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EPromptOptimizationAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PromptimConfig, global::G.DemoConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobCreate" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptOptimizationJobCreate(
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config)
        {
            this.Algorithm = algorithm;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobCreate" /> class.
        /// </summary>
        public PromptOptimizationJobCreate()
        {
        }
    }
}