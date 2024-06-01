//HintName: G.Models.WebhookIssuesLockedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesLockedIssueAuthorAssociation
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
    public static class WebhookIssuesLockedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesLockedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesLockedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesLockedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesLockedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesLockedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesLockedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesLockedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesLockedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesLockedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesLockedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesLockedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesLockedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesLockedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesLockedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesLockedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}