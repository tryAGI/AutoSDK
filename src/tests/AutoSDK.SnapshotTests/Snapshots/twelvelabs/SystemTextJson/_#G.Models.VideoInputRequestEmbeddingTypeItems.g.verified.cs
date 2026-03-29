//HintName: G.Models.VideoInputRequestEmbeddingTypeItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoInputRequestEmbeddingTypeItems
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
    public static class VideoInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                VideoInputRequestEmbeddingTypeItems.FusedEmbedding => "fused_embedding",
                VideoInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "fused_embedding" => VideoInputRequestEmbeddingTypeItems.FusedEmbedding,
                "separate_embedding" => VideoInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}