//HintName: G.Models.ServerMessageKnowledgeBaseRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "knowledge-base-request" is sent to request knowledge base documents. To enable, use `assistant.knowledgeBase.provider=custom-knowledge-base`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageKnowledgeBaseRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge-base-request")]
        KnowledgeBaseRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageKnowledgeBaseRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageKnowledgeBaseRequestType value)
        {
            return value switch
            {
                ServerMessageKnowledgeBaseRequestType.KnowledgeBaseRequest => "knowledge-base-request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageKnowledgeBaseRequestType? ToEnum(string value)
        {
            return value switch
            {
                "knowledge-base-request" => ServerMessageKnowledgeBaseRequestType.KnowledgeBaseRequest,
                _ => null,
            };
        }
    }
}