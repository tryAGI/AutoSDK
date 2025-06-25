﻿//HintName: G.Models.UsageCompletionsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageCompletionsBucketWidth
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
    public static class UsageCompletionsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCompletionsBucketWidth value)
        {
            return value switch
            {
                UsageCompletionsBucketWidth.x1m => "1m",
                UsageCompletionsBucketWidth.x1h => "1h",
                UsageCompletionsBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCompletionsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageCompletionsBucketWidth.x1m,
                "1h" => UsageCompletionsBucketWidth.x1h,
                "1d" => UsageCompletionsBucketWidth.x1d,
                _ => null,
            };
        }
    }
}