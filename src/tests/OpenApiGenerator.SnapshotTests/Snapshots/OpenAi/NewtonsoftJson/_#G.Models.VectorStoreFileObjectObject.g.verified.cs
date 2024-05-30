//HintName: G.Models.VectorStoreFileObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store.file`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store.file")]
        VectorStorefile,
    }

    public static class VectorStoreFileObjectObjectExtensions
    {
        public static string ToValueString(this VectorStoreFileObjectObject value)
        {
            return value switch
            {
                VectorStoreFileObjectObject.VectorStorefile => "vector_store.file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file" => VectorStoreFileObjectObject.VectorStorefile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreFileObjectObject.VectorStorefile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}