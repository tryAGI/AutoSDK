//HintName: G.Models.ParallelThinkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls computational intensity for the Research model. Cannot be used with streaming.
    /// </summary>
    public sealed partial class ParallelThinkingConfig
    {
        /// <summary>
        /// Computational intensity level. "none" is standard, "low" moderate, "high" maximum quality.<br/>
        /// Default Value: none
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ParallelThinkingConfigModeJsonConverter))]
        public global::G.ParallelThinkingConfigMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParallelThinkingConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Computational intensity level. "none" is standard, "low" moderate, "high" maximum quality.<br/>
        /// Default Value: none
        /// </param>
        public ParallelThinkingConfig(
            global::G.ParallelThinkingConfigMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParallelThinkingConfig" /> class.
        /// </summary>
        public ParallelThinkingConfig()
        {
        }
    }
}