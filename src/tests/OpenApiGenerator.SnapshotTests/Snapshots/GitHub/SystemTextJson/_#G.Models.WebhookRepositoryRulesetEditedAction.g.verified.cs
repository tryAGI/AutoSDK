//HintName: G.Models.WebhookRepositoryRulesetEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryRulesetEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryRulesetEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryRulesetEditedAction value)
        {
            return value switch
            {
                WebhookRepositoryRulesetEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryRulesetEditedAction ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookRepositoryRulesetEditedAction.Edited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}