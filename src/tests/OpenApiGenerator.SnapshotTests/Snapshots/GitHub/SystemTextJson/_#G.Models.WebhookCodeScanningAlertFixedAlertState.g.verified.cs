//HintName: G.Models.WebhookCodeScanningAlertFixedAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertFixedAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertFixedAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertState ToEnum(string value)
        {
            return value switch
            {
                "fixed" => WebhookCodeScanningAlertFixedAlertState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}