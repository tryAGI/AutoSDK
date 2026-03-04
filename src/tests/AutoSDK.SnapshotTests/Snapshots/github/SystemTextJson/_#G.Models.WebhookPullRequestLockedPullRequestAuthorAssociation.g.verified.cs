//HintName: G.Models.WebhookPullRequestLockedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestLockedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestLockedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestLockedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestLockedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestLockedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestLockedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestLockedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestLockedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestLockedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestLockedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}