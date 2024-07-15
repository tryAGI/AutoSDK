//HintName: G.Models.WebhookPullRequestDequeuedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dequeued")]
        Dequeued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedAction value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedAction.Dequeued => "dequeued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedAction? ToEnum(string value)
        {
            return value switch
            {
                "dequeued" => WebhookPullRequestDequeuedAction.Dequeued,
                _ => null,
            };
        }
    }
}