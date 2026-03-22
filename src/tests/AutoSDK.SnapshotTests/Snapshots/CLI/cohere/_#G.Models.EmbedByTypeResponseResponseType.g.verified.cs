//HintName: G.Models.EmbedByTypeResponseResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbedByTypeResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        EmbeddingsByType,
        /// <summary>
        /// 
        /// </summary>
        EmbeddingsFloats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedByTypeResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedByTypeResponseResponseType value)
        {
            return value switch
            {
                EmbedByTypeResponseResponseType.EmbeddingsByType => "embeddings_by_type",
                EmbedByTypeResponseResponseType.EmbeddingsFloats => "embeddings_floats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedByTypeResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "embeddings_by_type" => EmbedByTypeResponseResponseType.EmbeddingsByType,
                "embeddings_floats" => EmbedByTypeResponseResponseType.EmbeddingsFloats,
                _ => null,
            };
        }
    }
}