﻿//HintName: G.Models.VectorStoreFileBatchObjectObject.g.cs

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
        VectorStoreFilesBatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileBatchObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileBatchObjectObject value)
        {
            return value switch
            {
                VectorStoreFileBatchObjectObject.VectorStoreFilesBatch => "vector_store.files_batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileBatchObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.files_batch" => VectorStoreFileBatchObjectObject.VectorStoreFilesBatch,
                _ => null,
            };
        }
    }
}