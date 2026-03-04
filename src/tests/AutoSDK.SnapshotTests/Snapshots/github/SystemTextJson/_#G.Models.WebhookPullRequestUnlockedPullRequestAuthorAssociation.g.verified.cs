//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestUnlockedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestUnlockedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestUnlockedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}