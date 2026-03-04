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
    public static class WebhookIssuesReopenedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesReopenedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesReopenedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesReopenedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesReopenedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesReopenedIssueAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhookIssuesReopenedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesReopenedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesReopenedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesReopenedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesReopenedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesReopenedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}