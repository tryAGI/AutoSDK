//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedAlertState.Fixed => "fixed",
                WebhookCodeScanningAlertReopenedAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAlertState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertReopenedAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedAlertState.Fixed,
                "open" => WebhookCodeScanningAlertReopenedAlertState.Open,
                _ => null,
            };
        }
    }
}