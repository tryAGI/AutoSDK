//HintName: G.Models.AssistantMessageJudgePlanAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the judge plan.<br/>
    /// Use 'ai' to evaluate the assistant message content using LLM-as-a-judge.<br/>
    /// @default 'ai'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantMessageJudgePlanAIType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai")]
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageJudgePlanAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageJudgePlanAIType value)
        {
            return value switch
            {
                AssistantMessageJudgePlanAIType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageJudgePlanAIType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => AssistantMessageJudgePlanAIType.Ai,
                _ => null,
            };
        }
    }
}