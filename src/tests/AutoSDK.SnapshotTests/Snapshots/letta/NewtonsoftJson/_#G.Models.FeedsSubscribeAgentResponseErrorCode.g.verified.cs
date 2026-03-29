//HintName: G.Models.FeedsSubscribeAgentResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedsSubscribeAgentResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentAlreadySubscribed")]
        AgentAlreadySubscribed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentNotInProject")]
        AgentNotInProject,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalidCronExpression")]
        InvalidCronExpression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsSubscribeAgentResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsSubscribeAgentResponseErrorCode value)
        {
            return value switch
            {
                FeedsSubscribeAgentResponseErrorCode.AgentAlreadySubscribed => "agentAlreadySubscribed",
                FeedsSubscribeAgentResponseErrorCode.AgentNotInProject => "agentNotInProject",
                FeedsSubscribeAgentResponseErrorCode.InvalidCronExpression => "invalidCronExpression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsSubscribeAgentResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "agentAlreadySubscribed" => FeedsSubscribeAgentResponseErrorCode.AgentAlreadySubscribed,
                "agentNotInProject" => FeedsSubscribeAgentResponseErrorCode.AgentNotInProject,
                "invalidCronExpression" => FeedsSubscribeAgentResponseErrorCode.InvalidCronExpression,
                _ => null,
            };
        }
    }
}