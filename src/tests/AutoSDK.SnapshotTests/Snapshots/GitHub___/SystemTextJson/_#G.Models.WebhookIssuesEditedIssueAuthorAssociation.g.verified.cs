//HintName: G.Models.WebhookIssuesEditedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesEditedIssueAuthorAssociation
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
    public static class WebhookIssuesEditedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesEditedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesEditedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesEditedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesEditedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesEditedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesEditedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesEditedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesEditedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesEditedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesEditedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesEditedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesEditedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesEditedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesEditedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesEditedIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}