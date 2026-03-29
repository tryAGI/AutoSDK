//HintName: G.Models.ServerMessageUserInterruptedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "user-interrupted" is sent when the user interrupts the assistant.
    /// </summary>
    public enum ServerMessageUserInterruptedType
    {
        /// <summary>
        /// 
        /// </summary>
        UserInterrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageUserInterruptedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageUserInterruptedType value)
        {
            return value switch
            {
                ServerMessageUserInterruptedType.UserInterrupted => "user-interrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageUserInterruptedType? ToEnum(string value)
        {
            return value switch
            {
                "user-interrupted" => ServerMessageUserInterruptedType.UserInterrupted,
                _ => null,
            };
        }
    }
}