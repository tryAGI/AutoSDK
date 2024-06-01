//HintName: G.Models.WebhookIssuesUnassignedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action that was performed.
    /// </summary>
    public enum WebhookIssuesUnassignedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unassigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnassignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnassignedAction value)
        {
            return value switch
            {
                WebhookIssuesUnassignedAction.Unassigned => "unassigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnassignedAction ToEnum(string value)
        {
            return value switch
            {
                "unassigned" => WebhookIssuesUnassignedAction.Unassigned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}