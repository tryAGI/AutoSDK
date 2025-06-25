﻿//HintName: G.Models.ActionsGetActionsCacheListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: last_accessed_at
    /// </summary>
    public enum ActionsGetActionsCacheListSort
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        LastAccessedAt,
        /// <summary>
        /// 
        /// </summary>
        SizeInBytes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsGetActionsCacheListSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetActionsCacheListSort value)
        {
            return value switch
            {
                ActionsGetActionsCacheListSort.CreatedAt => "created_at",
                ActionsGetActionsCacheListSort.LastAccessedAt => "last_accessed_at",
                ActionsGetActionsCacheListSort.SizeInBytes => "size_in_bytes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetActionsCacheListSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ActionsGetActionsCacheListSort.CreatedAt,
                "last_accessed_at" => ActionsGetActionsCacheListSort.LastAccessedAt,
                "size_in_bytes" => ActionsGetActionsCacheListSort.SizeInBytes,
                _ => null,
            };
        }
    }
}