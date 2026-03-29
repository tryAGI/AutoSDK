//HintName: G.Models.ClientMessageUserInterruptedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "user-interrupted" is sent when the user interrupts the assistant.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageUserInterruptedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user-interrupted")]
        UserInterrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageUserInterruptedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageUserInterruptedType value)
        {
            return value switch
            {
                ClientMessageUserInterruptedType.UserInterrupted => "user-interrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageUserInterruptedType? ToEnum(string value)
        {
            return value switch
            {
                "user-interrupted" => ClientMessageUserInterruptedType.UserInterrupted,
                _ => null,
            };
        }
    }
}