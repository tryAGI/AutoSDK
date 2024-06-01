//HintName: G.Models.WebhookDiscussionLockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionLockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Locked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionLockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionLockedAction value)
        {
            return value switch
            {
                WebhookDiscussionLockedAction.Locked => "locked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionLockedAction ToEnum(string value)
        {
            return value switch
            {
                "locked" => WebhookDiscussionLockedAction.Locked,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}