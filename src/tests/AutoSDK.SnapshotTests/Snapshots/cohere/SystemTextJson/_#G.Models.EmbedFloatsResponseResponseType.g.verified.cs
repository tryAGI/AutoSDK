//HintName: G.Models.EmbedFloatsResponseResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbedFloatsResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        EmbeddingsFloats,
        /// <summary>
        /// 
        /// </summary>
        EmbeddingsByType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedFloatsResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedFloatsResponseResponseType value)
        {
            return value switch
            {
                EmbedFloatsResponseResponseType.EmbeddingsFloats => "embeddings_floats",
                EmbedFloatsResponseResponseType.EmbeddingsByType => "embeddings_by_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedFloatsResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "embeddings_floats" => EmbedFloatsResponseResponseType.EmbeddingsFloats,
                "embeddings_by_type" => EmbedFloatsResponseResponseType.EmbeddingsByType,
                _ => null,
            };
        }
    }
}