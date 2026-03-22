//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState
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
    public static class WebhookCodeScanningAlertReopenedAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Fixed => "fixed",
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Fixed,
                "open" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Open,
                _ => null,
            };
        }
    }
}