//HintName: G.Models.SecretScanningAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    public enum SecretScanningAlertState
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
    public static class SecretScanningAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertState value)
        {
            return value switch
            {
                SecretScanningAlertState.Open => "open",
                SecretScanningAlertState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertState? ToEnum(string value)
        {
            return value switch
            {
                "open" => SecretScanningAlertState.Open,
                "resolved" => SecretScanningAlertState.Resolved,
                _ => null,
            };
        }
    }
}