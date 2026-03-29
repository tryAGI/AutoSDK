//HintName: G.Models.ResponseEngineConversationFlowType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// type of the Response Engine.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseEngineConversationFlowType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation-flow")]
        ConversationFlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEngineConversationFlowTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEngineConversationFlowType value)
        {
            return value switch
            {
                ResponseEngineConversationFlowType.ConversationFlow => "conversation-flow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEngineConversationFlowType? ToEnum(string value)
        {
            return value switch
            {
                "conversation-flow" => ResponseEngineConversationFlowType.ConversationFlow,
                _ => null,
            };
        }
    }
}