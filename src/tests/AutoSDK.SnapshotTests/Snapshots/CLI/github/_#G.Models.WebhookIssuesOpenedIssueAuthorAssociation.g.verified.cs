//HintName: G.Models.WebhookIssuesOpenedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesOpenedIssueAuthorAssociation
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
    public static class WebhookIssuesOpenedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesOpenedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesOpenedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesOpenedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesOpenedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesOpenedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesOpenedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesOpenedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesOpenedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesOpenedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesOpenedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesOpenedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesOpenedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesOpenedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesOpenedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesOpenedIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}