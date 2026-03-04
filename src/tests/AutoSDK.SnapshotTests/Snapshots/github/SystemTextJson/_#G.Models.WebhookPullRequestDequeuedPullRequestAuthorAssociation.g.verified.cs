//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestDequeuedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestDequeuedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestDequeuedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}