//HintName: G.Models.WebhookIssuesDemilestonedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueAuthorAssociation
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
    public static class WebhookIssuesDemilestonedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesDemilestonedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesDemilestonedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesDemilestonedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesDemilestonedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesDemilestonedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesDemilestonedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesDemilestonedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesDemilestonedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesDemilestonedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}