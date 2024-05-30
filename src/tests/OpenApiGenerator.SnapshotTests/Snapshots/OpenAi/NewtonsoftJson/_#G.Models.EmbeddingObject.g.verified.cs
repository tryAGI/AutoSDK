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

    public static class EmbeddingObjectExtensions
    {
        public static string ToValueString(this EmbeddingObject value)
        {
            return value switch
            {
                EmbeddingObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmbeddingObject ToEnum(string value)
        {
            return value switch
            {
                "embedding" => EmbeddingObject.Embedding,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmbeddingObject ToEnum(int value)
        {
            return value switch
            {
                0 => EmbeddingObject.Embedding,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}