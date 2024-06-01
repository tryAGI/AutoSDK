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
    public static class WebhookPullRequestUnlabeledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestUnlabeledPullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestUnlabeledPullRequestAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}