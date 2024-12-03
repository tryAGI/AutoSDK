//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}