//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedByUserAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedByUserAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedByUserAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedByUserAlertState.Open => "open",
                WebhookCodeScanningAlertReopenedByUserAlertState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedByUserAlertState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertReopenedByUserAlertState.Open,
                "fixed" => WebhookCodeScanningAlertReopenedByUserAlertState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}