//HintName: G.Models.WebhooksIssue2AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksIssue2AuthorAssociation
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
    public static class WebhooksIssue2AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssue2AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksIssue2AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksIssue2AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksIssue2AuthorAssociation.Member => "MEMBER",
                WebhooksIssue2AuthorAssociation.None => "NONE",
                WebhooksIssue2AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssue2AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksIssue2AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksIssue2AuthorAssociation.Mannequin,
                "MEMBER" => WebhooksIssue2AuthorAssociation.Member,
                "NONE" => WebhooksIssue2AuthorAssociation.None,
                "OWNER" => WebhooksIssue2AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}