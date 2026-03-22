//HintName: G.Models.WebhooksIssue2State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhooksIssue2State
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2State value)
        {
            return value switch
            {
                WebhooksIssue2State.Closed => "closed",
                WebhooksIssue2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksIssue2State.Closed,
                "open" => WebhooksIssue2State.Open,
                _ => null,
            };
        }
    }
}