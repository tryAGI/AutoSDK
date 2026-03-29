//HintName: G.Models.AutomationRuleEvaluatorObjectObjectPublicAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorObjectObjectPublicAction
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
    public static class AutomationRuleEvaluatorObjectObjectPublicActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorObjectObjectPublicAction value)
        {
            return value switch
            {
                AutomationRuleEvaluatorObjectObjectPublicAction.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorObjectObjectPublicAction? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => AutomationRuleEvaluatorObjectObjectPublicAction.Evaluator,
                _ => null,
            };
        }
    }
}