//HintName: G.Models.WebhookIssuesDeletedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesDeletedIssueAuthorAssociation
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
    public static class WebhookIssuesDeletedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesDeletedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesDeletedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesDeletedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesDeletedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesDeletedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesDeletedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesDeletedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesDeletedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesDeletedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesDeletedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesDeletedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesDeletedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesDeletedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesDeletedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesDeletedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}