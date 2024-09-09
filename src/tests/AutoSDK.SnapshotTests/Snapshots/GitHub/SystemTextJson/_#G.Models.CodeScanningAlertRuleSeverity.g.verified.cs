//HintName: G.Models.CodeScanningAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum CodeScanningAlertRuleSeverity
    {
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
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertRuleSeverity value)
        {
            return value switch
            {
                CodeScanningAlertRuleSeverity.None => "none",
                CodeScanningAlertRuleSeverity.Note => "note",
                CodeScanningAlertRuleSeverity.Warning => "warning",
                CodeScanningAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "none" => CodeScanningAlertRuleSeverity.None,
                "note" => CodeScanningAlertRuleSeverity.Note,
                "warning" => CodeScanningAlertRuleSeverity.Warning,
                "error" => CodeScanningAlertRuleSeverity.Error,
                _ => null,
            };
        }
    }
}