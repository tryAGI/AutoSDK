//HintName: G.Models.WebhooksRulePullRequestReviewsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRulePullRequestReviewsEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        Everyone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRulePullRequestReviewsEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRulePullRequestReviewsEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRulePullRequestReviewsEnforcementLevel.Off => "off",
                WebhooksRulePullRequestReviewsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRulePullRequestReviewsEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRulePullRequestReviewsEnforcementLevel ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRulePullRequestReviewsEnforcementLevel.Off,
                "non_admins" => WebhooksRulePullRequestReviewsEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRulePullRequestReviewsEnforcementLevel.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}