//HintName: G.Models.RunRulesAlertType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for alert types.
    /// </summary>
    public enum RunRulesAlertType
    {
        /// <summary>
        /// 
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesAlertType value)
        {
            return value switch
            {
                RunRulesAlertType.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesAlertType? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => RunRulesAlertType.Pagerduty,
                _ => null,
            };
        }
    }
}