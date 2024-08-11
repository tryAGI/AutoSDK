//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueVariant1State
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1State value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1State.Open => "open",
                WebhookIssueCommentEditedIssueVariant1State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentEditedIssueVariant1State.Open,
                "closed" => WebhookIssueCommentEditedIssueVariant1State.Closed,
                _ => null,
            };
        }
    }
}