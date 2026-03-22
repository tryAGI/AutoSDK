//HintName: G.Models.EmbedFloatsResponseResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedFloatsResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings_by_type")]
        EmbeddingsByType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings_floats")]
        EmbeddingsFloats,
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
                EmbedFloatsResponseResponseType.EmbeddingsByType => "embeddings_by_type",
                EmbedFloatsResponseResponseType.EmbeddingsFloats => "embeddings_floats",
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
                "embeddings_by_type" => EmbedFloatsResponseResponseType.EmbeddingsByType,
                "embeddings_floats" => EmbedFloatsResponseResponseType.EmbeddingsFloats,
                _ => null,
            };
        }
    }
}