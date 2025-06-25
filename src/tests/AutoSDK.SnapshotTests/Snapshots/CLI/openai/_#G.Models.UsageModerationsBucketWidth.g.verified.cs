//HintName: G.Models.UsageModerationsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageModerationsBucketWidth
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
    public static class UsageModerationsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageModerationsBucketWidth value)
        {
            return value switch
            {
                UsageModerationsBucketWidth.x1m => "1m",
                UsageModerationsBucketWidth.x1h => "1h",
                UsageModerationsBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageModerationsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageModerationsBucketWidth.x1m,
                "1h" => UsageModerationsBucketWidth.x1h,
                "1d" => UsageModerationsBucketWidth.x1d,
                _ => null,
            };
        }
    }
}