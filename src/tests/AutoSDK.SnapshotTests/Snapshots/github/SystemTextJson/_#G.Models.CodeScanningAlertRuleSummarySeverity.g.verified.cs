//HintName: G.Models.CodeScanningAlertRuleSummarySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum CodeScanningAlertRuleSummarySeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Note,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertRuleSummarySeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertRuleSummarySeverity value)
        {
            return value switch
            {
                CodeScanningAlertRuleSummarySeverity.Error => "error",
                CodeScanningAlertRuleSummarySeverity.None => "none",
                CodeScanningAlertRuleSummarySeverity.Note => "note",
                CodeScanningAlertRuleSummarySeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertRuleSummarySeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => CodeScanningAlertRuleSummarySeverity.Error,
                "none" => CodeScanningAlertRuleSummarySeverity.None,
                "note" => CodeScanningAlertRuleSummarySeverity.Note,
                "warning" => CodeScanningAlertRuleSummarySeverity.Warning,
                _ => null,
            };
        }
    }
}