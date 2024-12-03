//HintName: G.Models.SecretScanningListAlertsForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum SecretScanningListAlertsForRepoSort
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
    public static class SecretScanningListAlertsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForRepoSort value)
        {
            return value switch
            {
                SecretScanningListAlertsForRepoSort.Created => "created",
                SecretScanningListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => SecretScanningListAlertsForRepoSort.Created,
                "updated" => SecretScanningListAlertsForRepoSort.Updated,
                _ => null,
            };
        }
    }
}