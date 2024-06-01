//HintName: G.Models.WebhookIssuesLabeledIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesLabeledIssueAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLabeledIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesLabeledIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesLabeledIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesLabeledIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesLabeledIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesLabeledIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesLabeledIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesLabeledIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesLabeledIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesLabeledIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesLabeledIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesLabeledIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesLabeledIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesLabeledIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesLabeledIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesLabeledIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}