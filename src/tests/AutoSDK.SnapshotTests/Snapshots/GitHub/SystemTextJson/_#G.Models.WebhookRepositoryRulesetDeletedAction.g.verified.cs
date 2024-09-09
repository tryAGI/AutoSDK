//HintName: G.Models.WebhookRepositoryRulesetDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryRulesetDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryRulesetDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryRulesetDeletedAction value)
        {
            return value switch
            {
                WebhookRepositoryRulesetDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryRulesetDeletedAction? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookRepositoryRulesetDeletedAction.Deleted,
                _ => null,
            };
        }
    }
}