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
    public static class WebhookIssuesLockedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesLockedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesLockedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesLockedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesLockedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesLockedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesLockedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesLockedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesLockedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesLockedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesLockedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesLockedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesLockedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesLockedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesLockedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesLockedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}