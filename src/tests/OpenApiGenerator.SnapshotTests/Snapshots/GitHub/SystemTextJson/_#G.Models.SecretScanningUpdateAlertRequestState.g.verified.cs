//HintName: G.Models.SecretScanningUpdateAlertRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    public enum SecretScanningUpdateAlertRequestState
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
    public static class SecretScanningUpdateAlertRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateAlertRequestState value)
        {
            return value switch
            {
                SecretScanningUpdateAlertRequestState.Open => "open",
                SecretScanningUpdateAlertRequestState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateAlertRequestState ToEnum(string value)
        {
            return value switch
            {
                "open" => SecretScanningUpdateAlertRequestState.Open,
                "resolved" => SecretScanningUpdateAlertRequestState.Resolved,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}