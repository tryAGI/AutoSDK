//HintName: G.Models.CodeScanningAlertSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Severity of a code scanning alert.
    /// </summary>
    public enum CodeScanningAlertSeverity
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
    public static class CodeScanningAlertSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertSeverity value)
        {
            return value switch
            {
                CodeScanningAlertSeverity.Critical => "critical",
                CodeScanningAlertSeverity.High => "high",
                CodeScanningAlertSeverity.Medium => "medium",
                CodeScanningAlertSeverity.Low => "low",
                CodeScanningAlertSeverity.Warning => "warning",
                CodeScanningAlertSeverity.Note => "note",
                CodeScanningAlertSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CodeScanningAlertSeverity.Critical,
                "high" => CodeScanningAlertSeverity.High,
                "medium" => CodeScanningAlertSeverity.Medium,
                "low" => CodeScanningAlertSeverity.Low,
                "warning" => CodeScanningAlertSeverity.Warning,
                "note" => CodeScanningAlertSeverity.Note,
                "error" => CodeScanningAlertSeverity.Error,
                _ => null,
            };
        }
    }
}