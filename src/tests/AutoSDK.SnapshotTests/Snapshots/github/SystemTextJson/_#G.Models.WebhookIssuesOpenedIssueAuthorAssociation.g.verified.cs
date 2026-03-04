//HintName: G.Models.WebhookIssuesOpenedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesOpenedIssueAuthorAssociation
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
    public static class WebhookIssuesOpenedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesOpenedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesOpenedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesOpenedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesOpenedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesOpenedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesOpenedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesOpenedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesOpenedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesOpenedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesOpenedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesOpenedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesOpenedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesOpenedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesOpenedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesOpenedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}