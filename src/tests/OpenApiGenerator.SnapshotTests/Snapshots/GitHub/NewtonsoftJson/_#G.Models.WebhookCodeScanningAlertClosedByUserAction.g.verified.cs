//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertClosedByUserAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed_by_user")]
        ClosedByUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertClosedByUserActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAction.ClosedByUser => "closed_by_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAction ToEnum(string value)
        {
            return value switch
            {
                "closed_by_user" => WebhookCodeScanningAlertClosedByUserAction.ClosedByUser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}