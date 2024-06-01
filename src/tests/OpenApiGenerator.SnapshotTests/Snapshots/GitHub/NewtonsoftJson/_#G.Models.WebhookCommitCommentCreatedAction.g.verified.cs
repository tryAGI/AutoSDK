//HintName: G.Models.WebhookCommitCommentCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action performed. Can be `created`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCommitCommentCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCommitCommentCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCommitCommentCreatedAction value)
        {
            return value switch
            {
                WebhookCommitCommentCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCommitCommentCreatedAction ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookCommitCommentCreatedAction.Created,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}