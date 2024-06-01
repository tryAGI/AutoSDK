//HintName: G.Models.OrganizationSecretScanningAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    public enum OrganizationSecretScanningAlertState
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
    public static class OrganizationSecretScanningAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSecretScanningAlertState value)
        {
            return value switch
            {
                OrganizationSecretScanningAlertState.Open => "open",
                OrganizationSecretScanningAlertState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSecretScanningAlertState ToEnum(string value)
        {
            return value switch
            {
                "open" => OrganizationSecretScanningAlertState.Open,
                "resolved" => OrganizationSecretScanningAlertState.Resolved,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}