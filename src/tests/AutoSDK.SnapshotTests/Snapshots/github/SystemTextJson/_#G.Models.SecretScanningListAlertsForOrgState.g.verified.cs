//HintName: G.Models.SecretScanningListAlertsForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretScanningListAlertsForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForOrgState value)
        {
            return value switch
            {
                SecretScanningListAlertsForOrgState.Open => "open",
                SecretScanningListAlertsForOrgState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForOrgState? ToEnum(string value)
        {
            return value switch
            {
                "open" => SecretScanningListAlertsForOrgState.Open,
                "resolved" => SecretScanningListAlertsForOrgState.Resolved,
                _ => null,
            };
        }
    }
}