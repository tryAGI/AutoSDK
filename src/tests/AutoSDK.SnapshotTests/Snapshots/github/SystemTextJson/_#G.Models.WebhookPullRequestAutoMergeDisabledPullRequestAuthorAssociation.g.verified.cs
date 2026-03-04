//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}