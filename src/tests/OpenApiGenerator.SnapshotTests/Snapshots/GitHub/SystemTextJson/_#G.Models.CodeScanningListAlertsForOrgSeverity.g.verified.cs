//HintName: G.Models.CodeScanningListAlertsForOrgSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Severity of a code scanning alert.
    /// </summary>
    public enum CodeScanningListAlertsForOrgSeverity
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
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Note,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListAlertsForOrgSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForOrgSeverity value)
        {
            return value switch
            {
                CodeScanningListAlertsForOrgSeverity.Critical => "critical",
                CodeScanningListAlertsForOrgSeverity.High => "high",
                CodeScanningListAlertsForOrgSeverity.Medium => "medium",
                CodeScanningListAlertsForOrgSeverity.Low => "low",
                CodeScanningListAlertsForOrgSeverity.Warning => "warning",
                CodeScanningListAlertsForOrgSeverity.Note => "note",
                CodeScanningListAlertsForOrgSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForOrgSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CodeScanningListAlertsForOrgSeverity.Critical,
                "high" => CodeScanningListAlertsForOrgSeverity.High,
                "medium" => CodeScanningListAlertsForOrgSeverity.Medium,
                "low" => CodeScanningListAlertsForOrgSeverity.Low,
                "warning" => CodeScanningListAlertsForOrgSeverity.Warning,
                "note" => CodeScanningListAlertsForOrgSeverity.Note,
                "error" => CodeScanningListAlertsForOrgSeverity.Error,
                _ => null,
            };
        }
    }
}