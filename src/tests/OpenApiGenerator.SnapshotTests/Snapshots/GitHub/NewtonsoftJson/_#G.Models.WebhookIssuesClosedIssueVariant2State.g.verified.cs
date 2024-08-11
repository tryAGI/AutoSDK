//HintName: G.Models.WebhookIssuesClosedIssueVariant2State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant2State
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant2State.Closed => "closed",
                WebhookIssuesClosedIssueVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesClosedIssueVariant2State.Closed,
                "open" => WebhookIssuesClosedIssueVariant2State.Open,
                _ => null,
            };
        }
    }
}