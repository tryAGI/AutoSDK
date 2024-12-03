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
    public static class WebhookPullRequestLockedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestLockedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestLockedPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestLockedPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestLockedPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestLockedPullRequestAuthorAssociation.OWNER => "OWNER",
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
                "COLLABORATOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestLockedPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestLockedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestLockedPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestLockedPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestLockedPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestLockedPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}