//HintName: G.Models.WebhookSponsorshipPendingCancellationAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSponsorshipPendingCancellationAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending_cancellation")]
        PendingCancellation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSponsorshipPendingCancellationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSponsorshipPendingCancellationAction value)
        {
            return value switch
            {
                WebhookSponsorshipPendingCancellationAction.PendingCancellation => "pending_cancellation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSponsorshipPendingCancellationAction ToEnum(string value)
        {
            return value switch
            {
                "pending_cancellation" => WebhookSponsorshipPendingCancellationAction.PendingCancellation,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}