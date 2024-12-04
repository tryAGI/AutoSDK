//HintName: G.Models.UsageCodeInterpreterSessionsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageCodeInterpreterSessionsBucketWidth
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
    public static class UsageCodeInterpreterSessionsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCodeInterpreterSessionsBucketWidth value)
        {
            return value switch
            {
                UsageCodeInterpreterSessionsBucketWidth.x1m => "1m",
                UsageCodeInterpreterSessionsBucketWidth.x1h => "1h",
                UsageCodeInterpreterSessionsBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCodeInterpreterSessionsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageCodeInterpreterSessionsBucketWidth.x1m,
                "1h" => UsageCodeInterpreterSessionsBucketWidth.x1h,
                "1d" => UsageCodeInterpreterSessionsBucketWidth.x1d,
                _ => null,
            };
        }
    }
}