//HintName: G.Models.AudioInputRequestEmbeddingTypeItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioInputRequestEmbeddingTypeItems
    {
        /// <summary>
        /// 
        /// </summary>
        FusedEmbedding,
        /// <summary>
        /// 
        /// </summary>
        SeparateEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                AudioInputRequestEmbeddingTypeItems.FusedEmbedding => "fused_embedding",
                AudioInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "fused_embedding" => AudioInputRequestEmbeddingTypeItems.FusedEmbedding,
                "separate_embedding" => AudioInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}