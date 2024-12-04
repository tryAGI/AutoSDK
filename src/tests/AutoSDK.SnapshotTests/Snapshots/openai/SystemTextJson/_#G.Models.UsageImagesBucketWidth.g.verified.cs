//HintName: G.Models.UsageImagesBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageImagesBucketWidth
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
    public static class UsageImagesBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesBucketWidth value)
        {
            return value switch
            {
                UsageImagesBucketWidth.x1m => "1m",
                UsageImagesBucketWidth.x1h => "1h",
                UsageImagesBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageImagesBucketWidth.x1m,
                "1h" => UsageImagesBucketWidth.x1h,
                "1d" => UsageImagesBucketWidth.x1d,
                _ => null,
            };
        }
    }
}