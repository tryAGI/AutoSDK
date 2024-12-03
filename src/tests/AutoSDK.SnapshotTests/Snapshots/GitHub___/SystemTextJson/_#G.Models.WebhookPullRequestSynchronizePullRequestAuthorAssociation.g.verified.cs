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
    public static class WebhookPullRequestSynchronizePullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestSynchronizePullRequestAuthorAssociation.OWNER => "OWNER",
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
                "COLLABORATOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestSynchronizePullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}