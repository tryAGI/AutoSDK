//HintName: G.Models.ListChunksResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ListChunksResponse message represents a response containing a list of chunks in the artifact system.
    /// </summary>
    public sealed partial class ListChunksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::G.Artifactv1alphaChunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}