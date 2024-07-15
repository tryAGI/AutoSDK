//HintName: G.Models.SecretScanningListAlertsForRepoState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningListAlertsForRepoState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForRepoState value)
        {
            return value switch
            {
                SecretScanningListAlertsForRepoState.Open => "open",
                SecretScanningListAlertsForRepoState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForRepoState? ToEnum(string value)
        {
            return value switch
            {
                "open" => SecretScanningListAlertsForRepoState.Open,
                "resolved" => SecretScanningListAlertsForRepoState.Resolved,
                _ => null,
            };
        }
    }
}