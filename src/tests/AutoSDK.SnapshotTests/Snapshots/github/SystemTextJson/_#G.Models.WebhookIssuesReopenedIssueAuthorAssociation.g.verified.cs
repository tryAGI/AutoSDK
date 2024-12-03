//HintName: G.Models.WebhookIssuesReopenedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesReopenedIssueAuthorAssociation
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
    public static class WebhookIssuesReopenedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesReopenedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesReopenedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesReopenedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesReopenedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesReopenedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesReopenedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesReopenedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesReopenedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesReopenedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesReopenedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesReopenedIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}