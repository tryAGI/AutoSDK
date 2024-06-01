//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
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
        public static WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}