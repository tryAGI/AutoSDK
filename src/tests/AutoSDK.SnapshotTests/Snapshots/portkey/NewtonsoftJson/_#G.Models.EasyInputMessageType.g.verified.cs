//HintName: G.Models.EasyInputMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the message input. Always `message`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EasyInputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageType value)
        {
            return value switch
            {
                EasyInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => EasyInputMessageType.Message,
                _ => null,
            };
        }
    }
}