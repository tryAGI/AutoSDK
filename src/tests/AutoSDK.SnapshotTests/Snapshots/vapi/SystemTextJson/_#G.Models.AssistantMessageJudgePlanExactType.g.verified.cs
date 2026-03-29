//HintName: G.Models.AssistantMessageJudgePlanExactType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the judge plan.<br/>
    /// Use 'exact' for an exact match on the content and tool calls - without using LLM-as-a-judge.<br/>
    /// @default 'exact'
    /// </summary>
    public enum AssistantMessageJudgePlanExactType
    {
        /// <summary>
        /// 
        /// </summary>
        Exact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageJudgePlanExactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageJudgePlanExactType value)
        {
            return value switch
            {
                AssistantMessageJudgePlanExactType.Exact => "exact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageJudgePlanExactType? ToEnum(string value)
        {
            return value switch
            {
                "exact" => AssistantMessageJudgePlanExactType.Exact,
                _ => null,
            };
        }
    }
}