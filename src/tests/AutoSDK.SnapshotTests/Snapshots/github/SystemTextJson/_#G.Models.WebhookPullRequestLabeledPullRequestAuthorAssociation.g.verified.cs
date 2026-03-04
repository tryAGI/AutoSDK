//HintName: G.Models.WebhookPullRequestLabeledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAuthorAssociation
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
    public static class WebhookPullRequestLabeledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestLabeledPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestLabeledPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestLabeledPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestLabeledPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestLabeledPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestLabeledPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestLabeledPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestLabeledPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestLabeledPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}