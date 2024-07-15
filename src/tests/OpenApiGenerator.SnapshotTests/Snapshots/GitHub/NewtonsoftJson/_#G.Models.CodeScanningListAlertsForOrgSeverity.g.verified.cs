//HintName: G.Models.CodeScanningListAlertsForOrgSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Severity of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningListAlertsForOrgSeverity
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