//HintName: G.Models.CodeScanningAlertRuleSummarySecuritySeverityLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security severity of the alert.
    /// </summary>
    public enum CodeScanningAlertRuleSummarySecuritySeverityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Critical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertRuleSummarySecuritySeverityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertRuleSummarySecuritySeverityLevel value)
        {
            return value switch
            {
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Low => "low",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Medium => "medium",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.High => "high",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertRuleSummarySecuritySeverityLevel? ToEnum(string value)
        {
            return value switch
            {
                "low" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Low,
                "medium" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Medium,
                "high" => CodeScanningAlertRuleSummarySecuritySeverityLevel.High,
                "critical" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Critical,
                _ => null,
            };
        }
    }
}