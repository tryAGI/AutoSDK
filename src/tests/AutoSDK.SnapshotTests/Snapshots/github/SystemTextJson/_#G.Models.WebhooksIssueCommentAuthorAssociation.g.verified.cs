//HintName: G.Models.WebhooksIssueCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksIssueCommentAuthorAssociation
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
    public static class WebhooksIssueCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksIssueCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksIssueCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksIssueCommentAuthorAssociation.Member => "MEMBER",
                WebhooksIssueCommentAuthorAssociation.None => "NONE",
                WebhooksIssueCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksIssueCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksIssueCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksIssueCommentAuthorAssociation.Member,
                "NONE" => WebhooksIssueCommentAuthorAssociation.None,
                "OWNER" => WebhooksIssueCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}