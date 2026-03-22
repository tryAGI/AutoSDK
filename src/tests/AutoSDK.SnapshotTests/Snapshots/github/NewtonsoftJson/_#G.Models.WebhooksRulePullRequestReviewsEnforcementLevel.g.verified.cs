//HintName: G.Models.WebhooksRulePullRequestReviewsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRulePullRequestReviewsEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everyone")]
        Everyone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_admins")]
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
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