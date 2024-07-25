//HintName: G.Models.RunRulesPagerdutyAlertSchemaSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for severity.
    /// </summary>
    public enum RunRulesPagerdutyAlertSchemaSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesPagerdutyAlertSchemaSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesPagerdutyAlertSchemaSeverity value)
        {
            return value switch
            {
                RunRulesPagerdutyAlertSchemaSeverity.Critical => "critical",
                RunRulesPagerdutyAlertSchemaSeverity.Warning => "warning",
                RunRulesPagerdutyAlertSchemaSeverity.Error => "error",
                RunRulesPagerdutyAlertSchemaSeverity.Info => "info",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesPagerdutyAlertSchemaSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => RunRulesPagerdutyAlertSchemaSeverity.Critical,
                "warning" => RunRulesPagerdutyAlertSchemaSeverity.Warning,
                "error" => RunRulesPagerdutyAlertSchemaSeverity.Error,
                "info" => RunRulesPagerdutyAlertSchemaSeverity.Info,
                _ => null,
            };
        }
    }
}