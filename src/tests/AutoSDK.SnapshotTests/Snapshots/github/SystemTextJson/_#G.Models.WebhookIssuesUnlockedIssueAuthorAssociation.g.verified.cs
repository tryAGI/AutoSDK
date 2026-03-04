//HintName: G.Models.WebhookIssuesUnlockedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesUnlockedIssueAuthorAssociation
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
    public static class WebhookIssuesUnlockedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesUnlockedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesUnlockedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesUnlockedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesUnlockedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesUnlockedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesUnlockedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesUnlockedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesUnlockedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesUnlockedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}