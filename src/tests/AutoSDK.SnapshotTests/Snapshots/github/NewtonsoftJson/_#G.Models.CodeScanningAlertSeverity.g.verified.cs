//HintName: G.Models.CodeScanningAlertSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Severity of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
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
                CodeScanningAlertSeverity.Error => "error",
                CodeScanningAlertSeverity.High => "high",
                CodeScanningAlertSeverity.Low => "low",
                CodeScanningAlertSeverity.Medium => "medium",
                CodeScanningAlertSeverity.Note => "note",
                CodeScanningAlertSeverity.Warning => "warning",
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
                "error" => CodeScanningAlertSeverity.Error,
                "high" => CodeScanningAlertSeverity.High,
                "low" => CodeScanningAlertSeverity.Low,
                "medium" => CodeScanningAlertSeverity.Medium,
                "note" => CodeScanningAlertSeverity.Note,
                "warning" => CodeScanningAlertSeverity.Warning,
                _ => null,
            };
        }
    }
}