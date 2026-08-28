//HintName: G.Models.EmbeddingDataEmbeddingScope2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scope for which the embedding was generated.<br/>
    /// **Values**:<br/>
    /// - `clip`: Embedding for a segment<br/>
    /// - `asset`: Embedding for the entire file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
    /// - `null`: For text and image embeddings
    /// </summary>
    public sealed partial class EmbeddingDataEmbeddingScope2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}