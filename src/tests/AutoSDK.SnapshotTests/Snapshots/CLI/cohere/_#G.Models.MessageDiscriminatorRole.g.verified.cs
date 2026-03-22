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
        Chatbot,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                MessageDiscriminatorRole.Chatbot => "CHATBOT",
                MessageDiscriminatorRole.System => "SYSTEM",
                MessageDiscriminatorRole.Tool => "TOOL",
                MessageDiscriminatorRole.User => "USER",
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
                "CHATBOT" => MessageDiscriminatorRole.Chatbot,
                "SYSTEM" => MessageDiscriminatorRole.System,
                "TOOL" => MessageDiscriminatorRole.Tool,
                "USER" => MessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}