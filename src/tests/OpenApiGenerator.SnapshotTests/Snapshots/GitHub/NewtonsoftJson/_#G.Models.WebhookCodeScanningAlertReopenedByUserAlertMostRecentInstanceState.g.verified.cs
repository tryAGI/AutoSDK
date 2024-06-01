//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState
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
    public static class WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}