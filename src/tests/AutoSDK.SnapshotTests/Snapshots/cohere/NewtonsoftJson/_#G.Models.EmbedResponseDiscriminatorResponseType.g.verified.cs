//HintName: G.Models.EmbedResponseDiscriminatorResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedResponseDiscriminatorResponseType
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
    public static class EmbedResponseDiscriminatorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedResponseDiscriminatorResponseType value)
        {
            return value switch
            {
                EmbedResponseDiscriminatorResponseType.EmbeddingsByType => "embeddings_by_type",
                EmbedResponseDiscriminatorResponseType.EmbeddingsFloats => "embeddings_floats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedResponseDiscriminatorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "embeddings_by_type" => EmbedResponseDiscriminatorResponseType.EmbeddingsByType,
                "embeddings_floats" => EmbedResponseDiscriminatorResponseType.EmbeddingsFloats,
                _ => null,
            };
        }
    }
}