//HintName: G.Models.MessagesRequestSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
    /// </summary>
    public enum MessagesRequestSpeed
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
    public static class MessagesRequestSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSpeed value)
        {
            return value switch
            {
                MessagesRequestSpeed.Fast => "fast",
                MessagesRequestSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => MessagesRequestSpeed.Fast,
                "standard" => MessagesRequestSpeed.Standard,
                _ => null,
            };
        }
    }
}