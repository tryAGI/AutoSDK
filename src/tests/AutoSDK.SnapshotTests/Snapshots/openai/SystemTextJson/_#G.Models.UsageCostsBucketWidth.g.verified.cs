//HintName: G.Models.UsageCostsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageCostsBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        x1d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCostsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCostsBucketWidth value)
        {
            return value switch
            {
                UsageCostsBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCostsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => UsageCostsBucketWidth.x1d,
                _ => null,
            };
        }
    }
}