//HintName: G.Models.InputMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the message input. Always set to `message`.
    /// </summary>
    public enum InputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageType value)
        {
            return value switch
            {
                InputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => InputMessageType.Message,
                _ => null,
            };
        }
    }
}