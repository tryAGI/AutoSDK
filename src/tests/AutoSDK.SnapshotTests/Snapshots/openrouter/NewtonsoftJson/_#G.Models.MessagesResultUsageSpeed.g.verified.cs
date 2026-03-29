//HintName: G.Models.MessagesResultUsageSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesResultUsageSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResultUsageSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResultUsageSpeed value)
        {
            return value switch
            {
                MessagesResultUsageSpeed.Fast => "fast",
                MessagesResultUsageSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResultUsageSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => MessagesResultUsageSpeed.Fast,
                "standard" => MessagesResultUsageSpeed.Standard,
                _ => null,
            };
        }
    }
}