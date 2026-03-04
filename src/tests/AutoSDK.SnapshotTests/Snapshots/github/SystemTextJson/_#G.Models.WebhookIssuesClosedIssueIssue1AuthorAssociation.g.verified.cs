//HintName: G.Models.WebhookIssuesClosedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1AuthorAssociation
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
    public static class WebhookIssuesClosedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssuesClosedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}