//HintName: G.Models.ChatModerationRequestInputVariant1ItemDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatModerationRequestInputVariant1ItemDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatModerationRequestInputVariant1ItemDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatModerationRequestInputVariant1ItemDiscriminatorRole value)
        {
            return value switch
            {
                ChatModerationRequestInputVariant1ItemDiscriminatorRole.Assistant => "assistant",
                ChatModerationRequestInputVariant1ItemDiscriminatorRole.System => "system",
                ChatModerationRequestInputVariant1ItemDiscriminatorRole.Tool => "tool",
                ChatModerationRequestInputVariant1ItemDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatModerationRequestInputVariant1ItemDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatModerationRequestInputVariant1ItemDiscriminatorRole.Assistant,
                "system" => ChatModerationRequestInputVariant1ItemDiscriminatorRole.System,
                "tool" => ChatModerationRequestInputVariant1ItemDiscriminatorRole.Tool,
                "user" => ChatModerationRequestInputVariant1ItemDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}