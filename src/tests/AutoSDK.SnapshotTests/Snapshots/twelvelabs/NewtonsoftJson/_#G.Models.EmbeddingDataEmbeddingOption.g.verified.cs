//HintName: G.Models.EmbeddingDataEmbeddingOption.g.cs

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
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingDataEmbeddingOption
    {
        /// <summary>
        /// Embedding based on audio content
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio content, and only when the `embedding_type` parameter in the request includes `fused_embedding`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fused")]
        Fused,
        /// <summary>
        /// Embedding based on transcribed speech
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription")]
        Transcription,
        /// <summary>
        /// Embedding based on visual content (video only)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="visual")]
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDataEmbeddingOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataEmbeddingOption value)
        {
            return value switch
            {
                EmbeddingDataEmbeddingOption.Audio => "audio",
                EmbeddingDataEmbeddingOption.Fused => "fused",
                EmbeddingDataEmbeddingOption.Transcription => "transcription",
                EmbeddingDataEmbeddingOption.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataEmbeddingOption? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbeddingDataEmbeddingOption.Audio,
                "fused" => EmbeddingDataEmbeddingOption.Fused,
                "transcription" => EmbeddingDataEmbeddingOption.Transcription,
                "visual" => EmbeddingDataEmbeddingOption.Visual,
                _ => null,
            };
        }
    }
}