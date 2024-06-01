//HintName: G.Models.WebhookIssuesMilestonedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesMilestonedIssueAuthorAssociation
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
    public static class WebhookIssuesMilestonedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesMilestonedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesMilestonedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesMilestonedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesMilestonedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesMilestonedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesMilestonedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesMilestonedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesMilestonedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesMilestonedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesMilestonedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesMilestonedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesMilestonedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}