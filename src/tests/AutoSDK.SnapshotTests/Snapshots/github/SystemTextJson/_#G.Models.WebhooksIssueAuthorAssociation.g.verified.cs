//HintName: G.Models.WebhooksIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksIssueAuthorAssociation
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
    public static class WebhooksIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksIssueAuthorAssociation.Member => "MEMBER",
                WebhooksIssueAuthorAssociation.None => "NONE",
                WebhooksIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksIssueAuthorAssociation.Member,
                "NONE" => WebhooksIssueAuthorAssociation.None,
                "OWNER" => WebhooksIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}