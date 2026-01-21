//HintName: G.Models.MessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHATBOT")]
        CHATBOT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM")]
        SYSTEM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER")]
        USER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL")]
        TOOL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDiscriminatorRole value)
        {
            return value switch
            {
                MessageDiscriminatorRole.CHATBOT => "CHATBOT",
                MessageDiscriminatorRole.SYSTEM => "SYSTEM",
                MessageDiscriminatorRole.USER => "USER",
                MessageDiscriminatorRole.TOOL => "TOOL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "CHATBOT" => MessageDiscriminatorRole.CHATBOT,
                "SYSTEM" => MessageDiscriminatorRole.SYSTEM,
                "USER" => MessageDiscriminatorRole.USER,
                "TOOL" => MessageDiscriminatorRole.TOOL,
                _ => null,
            };
        }
    }
}