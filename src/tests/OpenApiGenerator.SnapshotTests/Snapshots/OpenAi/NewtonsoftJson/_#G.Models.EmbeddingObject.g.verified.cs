//HintName: G.Models.EmbeddingObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "embedding".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingObject value)
        {
            return value switch
            {
                EmbeddingObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingObject ToEnum(string value)
        {
            return value switch
            {
                "embedding" => EmbeddingObject.Embedding,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}