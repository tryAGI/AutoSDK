//HintName: G.Models.VectorStoreObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store")]
        VectorStore,
    }

    public static class VectorStoreObjectObjectExtensions
    {
        public static string ToValueString(this VectorStoreObjectObject value)
        {
            return value switch
            {
                VectorStoreObjectObject.VectorStore => "vector_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreObjectObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store" => VectorStoreObjectObject.VectorStore,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreObjectObject.VectorStore,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}