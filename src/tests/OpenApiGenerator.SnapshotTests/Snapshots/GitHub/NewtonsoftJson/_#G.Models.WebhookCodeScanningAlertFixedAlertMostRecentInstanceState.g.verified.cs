//HintName: G.Models.WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertFixedAlertMostRecentInstanceState
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
    public static class WebhookCodeScanningAlertFixedAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertMostRecentInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertFixedAlertMostRecentInstanceState.Fixed,
                _ => null,
            };
        }
    }
}