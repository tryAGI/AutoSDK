﻿//HintName: G.Models.UsageEmbeddingsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageEmbeddingsBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageEmbeddingsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageEmbeddingsBucketWidth value)
        {
            return value switch
            {
                UsageEmbeddingsBucketWidth.x1m => "1m",
                UsageEmbeddingsBucketWidth.x1h => "1h",
                UsageEmbeddingsBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageEmbeddingsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageEmbeddingsBucketWidth.x1m,
                "1h" => UsageEmbeddingsBucketWidth.x1h,
                "1d" => UsageEmbeddingsBucketWidth.x1d,
                _ => null,
            };
        }
    }
}