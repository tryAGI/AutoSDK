//HintName: G.Models.RuleLogActionOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuleLogActionOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleLogActionOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleLogActionOutcome value)
        {
            return value switch
            {
                RuleLogActionOutcome.Error => "error",
                RuleLogActionOutcome.Skipped => "skipped",
                RuleLogActionOutcome.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleLogActionOutcome? ToEnum(string value)
        {
            return value switch
            {
                "error" => RuleLogActionOutcome.Error,
                "skipped" => RuleLogActionOutcome.Skipped,
                "success" => RuleLogActionOutcome.Success,
                _ => null,
            };
        }
    }
}