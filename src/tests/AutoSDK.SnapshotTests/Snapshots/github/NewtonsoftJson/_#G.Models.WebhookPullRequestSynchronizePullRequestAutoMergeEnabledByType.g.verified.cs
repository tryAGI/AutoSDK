﻿//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}