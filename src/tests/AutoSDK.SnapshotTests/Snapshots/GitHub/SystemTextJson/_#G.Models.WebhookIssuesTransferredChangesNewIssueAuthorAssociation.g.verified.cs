//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueAuthorAssociation
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
    public static class WebhookIssuesTransferredChangesNewIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}