//HintName: G.Models.CustomMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a custom message.
    /// </summary>
    public enum CustomMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomMessageType value)
        {
            return value switch
            {
                CustomMessageType.CustomMessage => "custom-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomMessageType? ToEnum(string value)
        {
            return value switch
            {
                "custom-message" => CustomMessageType.CustomMessage,
                _ => null,
            };
        }
    }
}