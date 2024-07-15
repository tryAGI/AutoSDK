//HintName: G.Models.CodeScanningListAlertsForRepoSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Severity of a code scanning alert.
    /// </summary>
    public enum CodeScanningListAlertsForRepoSeverity
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
    public static class CodeScanningListAlertsForRepoSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForRepoSeverity value)
        {
            return value switch
            {
                CodeScanningListAlertsForRepoSeverity.Critical => "critical",
                CodeScanningListAlertsForRepoSeverity.High => "high",
                CodeScanningListAlertsForRepoSeverity.Medium => "medium",
                CodeScanningListAlertsForRepoSeverity.Low => "low",
                CodeScanningListAlertsForRepoSeverity.Warning => "warning",
                CodeScanningListAlertsForRepoSeverity.Note => "note",
                CodeScanningListAlertsForRepoSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForRepoSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CodeScanningListAlertsForRepoSeverity.Critical,
                "high" => CodeScanningListAlertsForRepoSeverity.High,
                "medium" => CodeScanningListAlertsForRepoSeverity.Medium,
                "low" => CodeScanningListAlertsForRepoSeverity.Low,
                "warning" => CodeScanningListAlertsForRepoSeverity.Warning,
                "note" => CodeScanningListAlertsForRepoSeverity.Note,
                "error" => CodeScanningListAlertsForRepoSeverity.Error,
                _ => null,
            };
        }
    }
}