//HintName: G.Models.WebhookPullRequestAssignedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestAssignedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestAssignedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}