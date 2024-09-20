//HintName: G.Models.UpdateChunkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChunkResponse
    {
        /// <summary>
        /// The Chunk message represents a chunk of data in the artifact system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk")]
        public global::G.Artifactv1alphaChunk? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}