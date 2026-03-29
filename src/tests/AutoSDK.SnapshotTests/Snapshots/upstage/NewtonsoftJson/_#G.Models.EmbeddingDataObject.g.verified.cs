//HintName: G.Models.EmbeddingDataObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, always "embedding".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingDataObject
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
    public static class EmbeddingDataObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataObject value)
        {
            return value switch
            {
                EmbeddingDataObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => EmbeddingDataObject.Embedding,
                _ => null,
            };
        }
    }
}