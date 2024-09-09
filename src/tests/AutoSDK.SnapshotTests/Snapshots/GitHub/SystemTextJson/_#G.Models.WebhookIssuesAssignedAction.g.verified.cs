//HintName: G.Models.WebhookIssuesAssignedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action that was performed.
    /// </summary>
    public enum WebhookIssuesAssignedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Assigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesAssignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesAssignedAction value)
        {
            return value switch
            {
                WebhookIssuesAssignedAction.Assigned => "assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesAssignedAction? ToEnum(string value)
        {
            return value switch
            {
                "assigned" => WebhookIssuesAssignedAction.Assigned,
                _ => null,
            };
        }
    }
}