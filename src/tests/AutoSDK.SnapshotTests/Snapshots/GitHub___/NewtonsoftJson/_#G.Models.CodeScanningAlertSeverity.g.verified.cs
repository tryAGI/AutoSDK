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
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="note")]
        Note,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
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