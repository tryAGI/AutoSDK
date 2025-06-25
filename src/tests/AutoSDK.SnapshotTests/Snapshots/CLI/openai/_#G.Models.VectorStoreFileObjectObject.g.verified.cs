﻿//HintName: G.Models.VectorStoreFileObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store.file`.
    /// </summary>
    public enum VectorStoreFileObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileObjectObject value)
        {
            return value switch
            {
                VectorStoreFileObjectObject.VectorStoreFile => "vector_store.file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file" => VectorStoreFileObjectObject.VectorStoreFile,
                _ => null,
            };
        }
    }
}