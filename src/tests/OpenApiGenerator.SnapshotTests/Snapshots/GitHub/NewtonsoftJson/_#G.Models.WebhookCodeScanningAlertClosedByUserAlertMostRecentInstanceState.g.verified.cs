//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState
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
    public static class WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertClosedByUserAlertMostRecentInstanceState.Fixed,
                _ => null,
            };
        }
    }
}