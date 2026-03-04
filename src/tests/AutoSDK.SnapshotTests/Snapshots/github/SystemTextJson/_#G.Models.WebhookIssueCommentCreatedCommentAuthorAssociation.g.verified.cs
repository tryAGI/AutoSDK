//HintName: G.Models.WebhookIssueCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentCreatedCommentAuthorAssociation
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
    public static class WebhookIssueCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentCreatedCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentCreatedCommentAuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentCreatedCommentAuthorAssociation.None => "NONE",
                WebhookIssueCommentCreatedCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentCreatedCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentCreatedCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentCreatedCommentAuthorAssociation.Member,
                "NONE" => WebhookIssueCommentCreatedCommentAuthorAssociation.None,
                "OWNER" => WebhookIssueCommentCreatedCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}