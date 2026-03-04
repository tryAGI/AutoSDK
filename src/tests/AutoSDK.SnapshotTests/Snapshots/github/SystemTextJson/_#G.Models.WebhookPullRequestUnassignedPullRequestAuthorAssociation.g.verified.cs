//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestUnassignedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}