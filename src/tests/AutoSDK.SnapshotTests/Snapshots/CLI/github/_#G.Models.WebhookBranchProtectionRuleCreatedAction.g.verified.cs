//HintName: G.Models.WebhookBranchProtectionRuleCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBranchProtectionRuleCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleCreatedAction value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleCreatedAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookBranchProtectionRuleCreatedAction.Created,
                _ => null,
            };
        }
    }
}