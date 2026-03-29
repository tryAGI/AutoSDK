//HintName: G.Models.AutomationRuleEvaluatorPublicAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorPublicAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluator")]
        Evaluator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorPublicActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorPublicAction value)
        {
            return value switch
            {
                AutomationRuleEvaluatorPublicAction.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorPublicAction? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => AutomationRuleEvaluatorPublicAction.Evaluator,
                _ => null,
            };
        }
    }
}