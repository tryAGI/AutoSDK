//HintName: G.Models.Embedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an embedding vector returned by embedding endpoint.
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The index of the embedding in the list of embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The embedding vector, which is a list of floats. The length of vector depends on the model as listed in the [embedding guide](/docs/guides/embeddings).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Embedding1 { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public EmbeddingObject Object { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}