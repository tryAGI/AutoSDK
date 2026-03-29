//HintName: G.Models.ServerMessageAssistantRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "assistant-request" is sent to fetch assistant configuration for an incoming call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageAssistantRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request")]
        AssistantRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageAssistantRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageAssistantRequestType value)
        {
            return value switch
            {
                ServerMessageAssistantRequestType.AssistantRequest => "assistant-request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageAssistantRequestType? ToEnum(string value)
        {
            return value switch
            {
                "assistant-request" => ServerMessageAssistantRequestType.AssistantRequest,
                _ => null,
            };
        }
    }
}