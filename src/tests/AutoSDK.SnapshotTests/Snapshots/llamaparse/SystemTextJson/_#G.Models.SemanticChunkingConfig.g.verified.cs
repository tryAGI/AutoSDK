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
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buffer_size")]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Default Value: 95
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakpoint_percentile_threshold")]
        public int? BreakpointPercentileThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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