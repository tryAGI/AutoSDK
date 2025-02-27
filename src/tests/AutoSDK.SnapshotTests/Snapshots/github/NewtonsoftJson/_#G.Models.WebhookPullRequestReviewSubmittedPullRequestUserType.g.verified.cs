﻿//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewSubmittedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestUserType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}