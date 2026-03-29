//HintName: G.Models.BaseMessagesResultUsageSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultUsageSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultUsageSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultUsageSpeed value)
        {
            return value switch
            {
                BaseMessagesResultUsageSpeed.Fast => "fast",
                BaseMessagesResultUsageSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultUsageSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BaseMessagesResultUsageSpeed.Fast,
                "standard" => BaseMessagesResultUsageSpeed.Standard,
                _ => null,
            };
        }
    }
}