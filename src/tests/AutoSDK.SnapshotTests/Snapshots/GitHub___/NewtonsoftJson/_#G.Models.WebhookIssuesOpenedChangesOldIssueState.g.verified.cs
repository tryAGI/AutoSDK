//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssueState
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
    public static class WebhookIssuesOpenedChangesOldIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueState value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueState.Open => "open",
                WebhookIssuesOpenedChangesOldIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesOpenedChangesOldIssueState.Open,
                "closed" => WebhookIssuesOpenedChangesOldIssueState.Closed,
                _ => null,
            };
        }
    }
}