//HintName: G.Models.ServerMessageConversationUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "conversation-update" is sent when an update is committed to the conversation history.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageConversationUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation-update")]
        ConversationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageConversationUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageConversationUpdateType value)
        {
            return value switch
            {
                ServerMessageConversationUpdateType.ConversationUpdate => "conversation-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageConversationUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation-update" => ServerMessageConversationUpdateType.ConversationUpdate,
                _ => null,
            };
        }
    }
}