//HintName: G.Models.CodeScanningListAlertsForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    public enum CodeScanningListAlertsForOrgSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListAlertsForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForOrgSort value)
        {
            return value switch
            {
                CodeScanningListAlertsForOrgSort.Created => "created",
                CodeScanningListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForOrgSort ToEnum(string value)
        {
            return value switch
            {
                "created" => CodeScanningListAlertsForOrgSort.Created,
                "updated" => CodeScanningListAlertsForOrgSort.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}