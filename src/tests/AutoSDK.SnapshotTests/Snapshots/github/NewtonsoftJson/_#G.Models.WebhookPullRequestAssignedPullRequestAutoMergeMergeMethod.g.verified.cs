﻿//HintName: G.Models.WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squash")]
        Squash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rebase")]
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAssignedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestAssignedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}