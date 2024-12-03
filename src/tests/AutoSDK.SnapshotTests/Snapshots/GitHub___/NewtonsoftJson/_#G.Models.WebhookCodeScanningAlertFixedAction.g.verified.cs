//HintName: G.Models.WebhookCodeScanningAlertFixedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertFixedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertFixedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAction.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAction? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => WebhookCodeScanningAlertFixedAction.Fixed,
                _ => null,
            };
        }
    }
}