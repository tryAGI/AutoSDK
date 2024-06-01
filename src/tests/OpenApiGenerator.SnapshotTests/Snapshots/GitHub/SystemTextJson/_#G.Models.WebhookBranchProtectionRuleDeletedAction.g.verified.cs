//HintName: G.Models.WebhookBranchProtectionRuleDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBranchProtectionRuleDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleDeletedAction value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleDeletedAction ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookBranchProtectionRuleDeletedAction.Deleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}