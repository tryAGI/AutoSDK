//HintName: G.Models.SemanticChunkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SemanticChunkingConfig
    {
        /// <summary>
        /// Default Value: semantic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buffer_size")]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Default Value: 95
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakpoint_percentile_threshold")]
        public int? BreakpointPercentileThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticChunkingConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: semantic
        /// </param>
        /// <param name="bufferSize">
        /// Default Value: 1
        /// </param>
        /// <param name="breakpointPercentileThreshold">
        /// Default Value: 95
        /// </param>
        public SemanticChunkingConfig(
            string? mode,
            int? bufferSize,
            int? breakpointPercentileThreshold)
        {
            this.Mode = mode;
            this.BufferSize = bufferSize;
            this.BreakpointPercentileThreshold = breakpointPercentileThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticChunkingConfig" /> class.
        /// </summary>
        public SemanticChunkingConfig()
        {
        }
    }
}