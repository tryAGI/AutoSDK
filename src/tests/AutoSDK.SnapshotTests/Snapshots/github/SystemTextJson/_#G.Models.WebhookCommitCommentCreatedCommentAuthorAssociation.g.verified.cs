//HintName: G.Models.WebhookCommitCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookCommitCommentCreatedCommentAuthorAssociation
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
    public static class WebhookCommitCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCommitCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookCommitCommentCreatedCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookCommitCommentCreatedCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookCommitCommentCreatedCommentAuthorAssociation.Member => "MEMBER",
                WebhookCommitCommentCreatedCommentAuthorAssociation.None => "NONE",
                WebhookCommitCommentCreatedCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCommitCommentCreatedCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookCommitCommentCreatedCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookCommitCommentCreatedCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhookCommitCommentCreatedCommentAuthorAssociation.Member,
                "NONE" => WebhookCommitCommentCreatedCommentAuthorAssociation.None,
                "OWNER" => WebhookCommitCommentCreatedCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}