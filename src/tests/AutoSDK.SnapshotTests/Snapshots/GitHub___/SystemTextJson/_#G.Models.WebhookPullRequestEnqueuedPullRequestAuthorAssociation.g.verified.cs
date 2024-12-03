//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestEnqueuedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}