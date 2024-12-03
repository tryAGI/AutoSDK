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
    public static class WebhookPullRequestUnassignedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.OWNER => "OWNER",
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
                "COLLABORATOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}