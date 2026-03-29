//HintName: G.Models.ProsodyModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProsodyModelConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProsodyModelConfigGranularityJsonConverter))]
        public global::G.ProsodyModelConfigGranularity? Granularity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identify_speakers")]
        public bool? IdentifySpeakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyModelConfig" /> class.
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="identifySpeakers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProsodyModelConfig(
            global::G.ProsodyModelConfigGranularity? granularity,
            bool? identifySpeakers)
        {
            this.Granularity = granularity;
            this.IdentifySpeakers = identifySpeakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyModelConfig" /> class.
        /// </summary>
        public ProsodyModelConfig()
        {
        }
    }
}