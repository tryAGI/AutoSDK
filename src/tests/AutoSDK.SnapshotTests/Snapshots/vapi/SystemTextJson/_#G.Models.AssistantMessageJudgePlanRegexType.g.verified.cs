//HintName: G.Models.AssistantMessageJudgePlanRegexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the judge plan.<br/>
    /// Use 'regex' for a regex match on the content and tool calls - without using LLM-as-a-judge.<br/>
    /// @default 'regex'
    /// </summary>
    public enum AssistantMessageJudgePlanRegexType
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageJudgePlanRegexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageJudgePlanRegexType value)
        {
            return value switch
            {
                AssistantMessageJudgePlanRegexType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageJudgePlanRegexType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => AssistantMessageJudgePlanRegexType.Regex,
                _ => null,
            };
        }
    }
}