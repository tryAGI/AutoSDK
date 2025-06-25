﻿//HintName: G.Models.CodeScanningAlertRuleSecuritySeverityLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security severity of the alert.
    /// </summary>
    public enum CodeScanningAlertRuleSecuritySeverityLevel
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
    public static class CodeScanningAlertRuleSecuritySeverityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertRuleSecuritySeverityLevel value)
        {
            return value switch
            {
                CodeScanningAlertRuleSecuritySeverityLevel.Low => "low",
                CodeScanningAlertRuleSecuritySeverityLevel.Medium => "medium",
                CodeScanningAlertRuleSecuritySeverityLevel.High => "high",
                CodeScanningAlertRuleSecuritySeverityLevel.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertRuleSecuritySeverityLevel? ToEnum(string value)
        {
            return value switch
            {
                "low" => CodeScanningAlertRuleSecuritySeverityLevel.Low,
                "medium" => CodeScanningAlertRuleSecuritySeverityLevel.Medium,
                "high" => CodeScanningAlertRuleSecuritySeverityLevel.High,
                "critical" => CodeScanningAlertRuleSecuritySeverityLevel.Critical,
                _ => null,
            };
        }
    }
}