//HintName: G.Models.CodeScanningListAlertsForOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum CodeScanningListAlertsForOrgDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListAlertsForOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForOrgDirection value)
        {
            return value switch
            {
                CodeScanningListAlertsForOrgDirection.Asc => "asc",
                CodeScanningListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForOrgDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CodeScanningListAlertsForOrgDirection.Asc,
                "desc" => CodeScanningListAlertsForOrgDirection.Desc,
                _ => null,
            };
        }
    }
}