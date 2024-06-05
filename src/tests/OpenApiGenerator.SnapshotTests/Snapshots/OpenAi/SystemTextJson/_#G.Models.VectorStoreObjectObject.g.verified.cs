//HintName: G.Models.VectorStoreObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store`.
    /// </summary>
    public enum VectorStoreObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreObjectObject value)
        {
            return value switch
            {
                VectorStoreObjectObject.VectorStore => "vector_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store" => VectorStoreObjectObject.VectorStore,
                _ => null,
            };
        }
    }
}