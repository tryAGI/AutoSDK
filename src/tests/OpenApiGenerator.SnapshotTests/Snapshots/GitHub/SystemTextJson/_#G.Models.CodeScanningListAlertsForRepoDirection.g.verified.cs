//HintName: G.Models.CodeScanningListAlertsForRepoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum CodeScanningListAlertsForRepoDirection
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
    public static class CodeScanningListAlertsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForRepoDirection value)
        {
            return value switch
            {
                CodeScanningListAlertsForRepoDirection.Asc => "asc",
                CodeScanningListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForRepoDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CodeScanningListAlertsForRepoDirection.Asc,
                "desc" => CodeScanningListAlertsForRepoDirection.Desc,
                _ => null,
            };
        }
    }
}