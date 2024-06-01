//HintName: G.Models.WebhookIssuesUnlabeledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlabeledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unlabeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlabeledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlabeledAction value)
        {
            return value switch
            {
                WebhookIssuesUnlabeledAction.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlabeledAction ToEnum(string value)
        {
            return value switch
            {
                "unlabeled" => WebhookIssuesUnlabeledAction.Unlabeled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}