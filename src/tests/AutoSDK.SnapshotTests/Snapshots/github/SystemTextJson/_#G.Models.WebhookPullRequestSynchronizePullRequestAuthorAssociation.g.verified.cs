//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestAuthorAssociation
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
    public static class WebhookPullRequestSynchronizePullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}