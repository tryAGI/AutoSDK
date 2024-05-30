//HintName: G.Models.VectorStoreFileBatchObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store.file_batch`.
    /// </summary>
    public enum VectorStoreFileBatchObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStorefilesBatch,
    }

    public static class VectorStoreFileBatchObjectObjectExtensions
    {
        public static string ToValueString(this VectorStoreFileBatchObjectObject value)
        {
            return value switch
            {
                VectorStoreFileBatchObjectObject.VectorStorefilesBatch => "vector_store.files_batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileBatchObjectObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store.files_batch" => VectorStoreFileBatchObjectObject.VectorStorefilesBatch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileBatchObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreFileBatchObjectObject.VectorStorefilesBatch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}