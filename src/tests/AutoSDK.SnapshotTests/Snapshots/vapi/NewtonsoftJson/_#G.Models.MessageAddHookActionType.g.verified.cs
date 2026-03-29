//HintName: G.Models.MessageAddHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "message.add"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageAddHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message.add")]
        MessageAdd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageAddHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageAddHookActionType value)
        {
            return value switch
            {
                MessageAddHookActionType.MessageAdd => "message.add",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageAddHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "message.add" => MessageAddHookActionType.MessageAdd,
                _ => null,
            };
        }
    }
}