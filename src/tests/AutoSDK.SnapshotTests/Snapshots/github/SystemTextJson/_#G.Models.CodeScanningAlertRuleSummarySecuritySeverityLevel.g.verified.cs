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
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
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
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Critical => "critical",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.High => "high",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Low => "low",
                CodeScanningAlertRuleSummarySecuritySeverityLevel.Medium => "medium",
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
                "critical" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Critical,
                "high" => CodeScanningAlertRuleSummarySecuritySeverityLevel.High,
                "low" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Low,
                "medium" => CodeScanningAlertRuleSummarySecuritySeverityLevel.Medium,
                _ => null,
            };
        }
    }
}