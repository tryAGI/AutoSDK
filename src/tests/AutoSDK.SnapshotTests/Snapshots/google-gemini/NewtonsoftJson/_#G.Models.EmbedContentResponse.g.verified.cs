//HintName: G.Models.EmbedContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to an `EmbedContentRequest`.
    /// </summary>
    public sealed partial class EmbedContentResponse
    {
        /// <summary>
        /// A list of floats representing an embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::G.ContentEmbedding? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}