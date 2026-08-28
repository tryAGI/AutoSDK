//HintName: G.Models.EmbeddingDataEmbeddingOption2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The modality used to generate this embedding.<br/>
    ///   **Values**:<br/>
    ///  - `visual`: Embedding based on visual content (video only)<br/>
    ///  - `audio`: Embedding based on audio content<br/>
    ///  - `transcription`: Embedding based on transcribed speech<br/>
    ///  - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio content, and only when the `embedding_type` parameter in the request includes `fused_embedding`.<br/>
    ///  - `null`: For text and image embeddings
    /// </summary>
    public sealed partial class EmbeddingDataEmbeddingOption2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}