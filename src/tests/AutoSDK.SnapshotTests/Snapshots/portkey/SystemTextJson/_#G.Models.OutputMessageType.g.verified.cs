//HintName: G.Models.OutputMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the output message. Always `message`.
    /// </summary>
    public enum OutputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageType value)
        {
            return value switch
            {
                OutputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => OutputMessageType.Message,
                _ => null,
            };
        }
    }
}