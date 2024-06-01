//HintName: G.Models.SecretScanningListAlertsForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    public enum SecretScanningListAlertsForOrgSort
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
    public static class SecretScanningListAlertsForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForOrgSort value)
        {
            return value switch
            {
                SecretScanningListAlertsForOrgSort.Created => "created",
                SecretScanningListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForOrgSort ToEnum(string value)
        {
            return value switch
            {
                "created" => SecretScanningListAlertsForOrgSort.Created,
                "updated" => SecretScanningListAlertsForOrgSort.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}