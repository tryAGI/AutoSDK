//HintName: G.Models.CodeScanningAlertRuleSummarySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertRuleSummarySeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="note")]
        Note,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
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