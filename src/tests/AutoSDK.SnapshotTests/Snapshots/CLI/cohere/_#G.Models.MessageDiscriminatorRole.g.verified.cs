//HintName: G.Models.MessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        CHATBOT,
        /// <summary>
        /// 
        /// </summary>
        SYSTEM,
        /// <summary>
        /// 
        /// </summary>
        TOOL,
        /// <summary>
        /// 
        /// </summary>
        USER,
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
                MessageDiscriminatorRole.TOOL => "TOOL",
                MessageDiscriminatorRole.USER => "USER",
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
                "TOOL" => MessageDiscriminatorRole.TOOL,
                "USER" => MessageDiscriminatorRole.USER,
                _ => null,
            };
        }
    }
}