//HintName: G.Models.EmbeddingData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An embedding with its metadata.
    /// </summary>
    public sealed partial class EmbeddingData
    {
        /// <summary>
        /// The embedding vector for the content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Embedding { get; set; } = default!;

        /// <summary>
        /// The modality used to generate this embedding.<br/>
        ///   **Values**:<br/>
        ///  - `visual`: Embedding based on visual content (video only)<br/>
        ///  - `audio`: Embedding based on audio content<br/>
        ///  - `transcription`: Embedding based on transcribed speech<br/>
        ///  - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio content, and only when the `embedding_type` parameter in the request includes `fused_embedding`.<br/>
        ///  - `null`: For text and image embeddings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_option")]
        public global::G.OneOf<global::G.EmbeddingDataEmbeddingOption?, object>? EmbeddingOption { get; set; }

        /// <summary>
        /// The scope for which the embedding was generated.<br/>
        /// **Values**:<br/>
        /// - `clip`: Embedding for a segment<br/>
        /// - `asset`: Embedding for the entire file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// - `null`: For text and image embeddings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_scope")]
        public global::G.OneOf<global::G.EmbeddingDataEmbeddingScope?, object>? EmbeddingScope { get; set; }

        /// <summary>
        /// The start time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The end time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        /// <param name="embedding">
        /// The embedding vector for the content.
        /// </param>
        /// <param name="embeddingOption">
        /// The modality used to generate this embedding.<br/>
        ///   **Values**:<br/>
        ///  - `visual`: Embedding based on visual content (video only)<br/>
        ///  - `audio`: Embedding based on audio content<br/>
        ///  - `transcription`: Embedding based on transcribed speech<br/>
        ///  - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio content, and only when the `embedding_type` parameter in the request includes `fused_embedding`.<br/>
        ///  - `null`: For text and image embeddings
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which the embedding was generated.<br/>
        /// **Values**:<br/>
        /// - `clip`: Embedding for a segment<br/>
        /// - `asset`: Embedding for the entire file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// - `null`: For text and image embeddings
        /// </param>
        /// <param name="startSec">
        /// The start time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </param>
        /// <param name="endSec">
        /// The end time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </param>
        public EmbeddingData(
            global::System.Collections.Generic.IList<double> embedding,
            global::G.OneOf<global::G.EmbeddingDataEmbeddingOption?, object>? embeddingOption,
            global::G.OneOf<global::G.EmbeddingDataEmbeddingScope?, object>? embeddingScope,
            double? startSec,
            double? endSec)
        {
            this.Embedding = embedding ?? throw new global::System.ArgumentNullException(nameof(embedding));
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingScope = embeddingScope;
            this.StartSec = startSec;
            this.EndSec = endSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        public EmbeddingData()
        {
        }
    }
}