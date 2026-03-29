//HintName: G.Models.ChatResponseChatStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of chat.<br/>
    /// - `ongoing`: Chat session is ongoing, chat agent can receive new message and generate response.<br/>
    /// - `ended`: Chat session has ended, and no longer can generate new response.<br/>
    /// - `error`: Chat encountered error.<br/>
    /// Example: ongoing
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatResponseChatStatus
    {
        /// <summary>
        /// Chat session has ended, and no longer can generate new response.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
        /// <summary>
        /// Chat encountered error.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// Chat session is ongoing, chat agent can receive new message and generate response.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ongoing")]
        Ongoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatResponseChatStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResponseChatStatus value)
        {
            return value switch
            {
                ChatResponseChatStatus.Ended => "ended",
                ChatResponseChatStatus.Error => "error",
                ChatResponseChatStatus.Ongoing => "ongoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResponseChatStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => ChatResponseChatStatus.Ended,
                "error" => ChatResponseChatStatus.Error,
                "ongoing" => ChatResponseChatStatus.Ongoing,
                _ => null,
            };
        }
    }
}