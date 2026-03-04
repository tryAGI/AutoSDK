//HintName: G.Models.WebhooksReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksReviewAuthorAssociation
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
    public static class WebhooksReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhooksReviewAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksReviewAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksReviewAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksReviewAuthorAssociation.Member => "MEMBER",
                WebhooksReviewAuthorAssociation.None => "NONE",
                WebhooksReviewAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksReviewAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksReviewAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksReviewAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksReviewAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksReviewAuthorAssociation.Member,
                "NONE" => WebhooksReviewAuthorAssociation.None,
                "OWNER" => WebhooksReviewAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}