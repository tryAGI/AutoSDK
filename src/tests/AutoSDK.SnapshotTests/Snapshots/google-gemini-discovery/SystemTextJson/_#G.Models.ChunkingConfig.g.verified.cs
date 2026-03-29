//HintName: G.Models.ChunkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
    /// </summary>
    public sealed partial class ChunkingConfig
    {
        /// <summary>
        /// Configuration for a white space chunking algorithm [white space delimited].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whiteSpaceConfig")]
        public global::G.WhiteSpaceConfig? WhiteSpaceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfig" /> class.
        /// </summary>
        /// <param name="whiteSpaceConfig">
        /// Configuration for a white space chunking algorithm [white space delimited].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkingConfig(
            global::G.WhiteSpaceConfig? whiteSpaceConfig)
        {
            this.WhiteSpaceConfig = whiteSpaceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfig" /> class.
        /// </summary>
        public ChunkingConfig()
        {
        }
    }
}