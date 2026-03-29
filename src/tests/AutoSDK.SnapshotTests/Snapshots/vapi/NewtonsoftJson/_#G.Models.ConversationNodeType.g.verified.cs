//HintName: G.Models.ConversationNodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the Conversation node. This can be used to start a conversation with the customer.<br/>
    /// The flow is:<br/>
    /// - Workflow starts the conversation node<br/>
    /// - Model is active with the `prompt` and global context.<br/>
    /// - Model will call a tool to exit this node.<br/>
    /// - Workflow will extract variables from the conversation.<br/>
    /// - Workflow continues.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation")]
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationNodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationNodeType value)
        {
            return value switch
            {
                ConversationNodeType.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationNodeType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => ConversationNodeType.Conversation,
                _ => null,
            };
        }
    }
}