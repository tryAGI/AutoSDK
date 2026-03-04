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
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Owner,
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
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.None => "NONE",
                WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesTransferredChangesNewIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}