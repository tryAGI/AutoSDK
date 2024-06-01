//HintName: G.Models.WebhookIssuesDemilestonedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Demilestoned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesDemilestonedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedAction value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedAction.Demilestoned => "demilestoned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedAction ToEnum(string value)
        {
            return value switch
            {
                "demilestoned" => WebhookIssuesDemilestonedAction.Demilestoned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}