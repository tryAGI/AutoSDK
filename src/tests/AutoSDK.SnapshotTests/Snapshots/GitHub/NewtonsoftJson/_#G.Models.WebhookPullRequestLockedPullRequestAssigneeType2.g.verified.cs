﻿//HintName: G.Models.WebhookPullRequestLockedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestAssigneeType2
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
    public static class WebhookPullRequestLockedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestLockedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestLockedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestLockedPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestLockedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestLockedPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestLockedPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}