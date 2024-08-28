//HintName: G.Models.EmbedByTypeResponseResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedByTypeResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings_floats")]
        EmbeddingsFloats,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings_by_type")]
        EmbeddingsByType,
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
                EmbedByTypeResponseResponseType.EmbeddingsFloats => "embeddings_floats",
                EmbedByTypeResponseResponseType.EmbeddingsByType => "embeddings_by_type",
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
                "embeddings_floats" => EmbedByTypeResponseResponseType.EmbeddingsFloats,
                "embeddings_by_type" => EmbedByTypeResponseResponseType.EmbeddingsByType,
                _ => null,
            };
        }
    }
}