﻿//HintName: G.Models.DeleteVectorStoreFileResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteVectorStoreFileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteVectorStoreFileResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVectorStoreFileResponseObject value)
        {
            return value switch
            {
                DeleteVectorStoreFileResponseObject.VectorStoreFileDeleted => "vector_store.file.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVectorStoreFileResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file.deleted" => DeleteVectorStoreFileResponseObject.VectorStoreFileDeleted,
                _ => null,
            };
        }
    }
}