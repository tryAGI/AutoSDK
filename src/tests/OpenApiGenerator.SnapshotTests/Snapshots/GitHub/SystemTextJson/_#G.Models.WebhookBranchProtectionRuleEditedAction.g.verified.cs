//HintName: G.Models.WebhookBranchProtectionRuleEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBranchProtectionRuleEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedAction value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleEditedAction ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookBranchProtectionRuleEditedAction.Edited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}