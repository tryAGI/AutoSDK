//HintName: G.Models.RuleLogActionOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleLogActionOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
                RuleLogActionOutcome.Success => "success",
                RuleLogActionOutcome.Skipped => "skipped",
                RuleLogActionOutcome.Error => "error",
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
                "success" => RuleLogActionOutcome.Success,
                "skipped" => RuleLogActionOutcome.Skipped,
                "error" => RuleLogActionOutcome.Error,
                _ => null,
            };
        }
    }
}