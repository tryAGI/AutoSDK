//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestAuthorAssociation
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
    public static class WebhookPullRequestUnlabeledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}