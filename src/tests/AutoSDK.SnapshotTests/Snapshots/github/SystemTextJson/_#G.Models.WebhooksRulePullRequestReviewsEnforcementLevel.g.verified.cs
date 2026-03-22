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
        Everyone,
        /// <summary>
        /// 
        /// </summary>
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        Off,
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
                WebhooksRulePullRequestReviewsEnforcementLevel.Everyone => "everyone",
                WebhooksRulePullRequestReviewsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRulePullRequestReviewsEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRulePullRequestReviewsEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRulePullRequestReviewsEnforcementLevel.Everyone,
                "non_admins" => WebhooksRulePullRequestReviewsEnforcementLevel.NonAdmins,
                "off" => WebhooksRulePullRequestReviewsEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}