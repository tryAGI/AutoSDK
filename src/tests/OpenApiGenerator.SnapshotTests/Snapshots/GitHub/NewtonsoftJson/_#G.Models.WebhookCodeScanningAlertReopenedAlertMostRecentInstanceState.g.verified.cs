//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
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
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Fixed => "fixed",
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
                "open" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedAlertMostRecentInstanceState.Fixed,
                _ => null,
            };
        }
    }
}