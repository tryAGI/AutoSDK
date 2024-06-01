//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertClosedByUserAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertClosedByUserAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertClosedByUserAlertState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertState ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertClosedByUserAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertClosedByUserAlertState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}