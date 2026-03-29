//HintName: G.Models.FeedsSubscribeAgentResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsSubscribeAgentResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AgentAlreadySubscribed,
        /// <summary>
        /// 
        /// </summary>
        AgentNotInProject,
        /// <summary>
        /// 
        /// </summary>
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