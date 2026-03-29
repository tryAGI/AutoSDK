//HintName: G.Models.AutomationRuleEvaluatorWriteAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorWriteAction
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
    public static class AutomationRuleEvaluatorWriteActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorWriteAction value)
        {
            return value switch
            {
                AutomationRuleEvaluatorWriteAction.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorWriteAction? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => AutomationRuleEvaluatorWriteAction.Evaluator,
                _ => null,
            };
        }
    }
}