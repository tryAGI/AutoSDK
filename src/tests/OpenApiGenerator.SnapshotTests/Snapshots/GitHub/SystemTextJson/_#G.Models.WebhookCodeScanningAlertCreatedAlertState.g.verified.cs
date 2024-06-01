//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertCreatedAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertCreatedAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertCreatedAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertCreatedAlertState.Open => "open",
                WebhookCodeScanningAlertCreatedAlertState.Dismissed => "dismissed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertCreatedAlertState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertCreatedAlertState.Open,
                "dismissed" => WebhookCodeScanningAlertCreatedAlertState.Dismissed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}