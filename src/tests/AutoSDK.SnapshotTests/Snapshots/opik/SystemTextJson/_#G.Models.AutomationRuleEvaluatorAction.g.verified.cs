//HintName: G.Models.AutomationRuleEvaluatorAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorAction
    {
        /// <summary>
        /// 
        /// </summary>
        Evaluator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorAction value)
        {
            return value switch
            {
                AutomationRuleEvaluatorAction.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorAction? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => AutomationRuleEvaluatorAction.Evaluator,
                _ => null,
            };
        }
    }
}