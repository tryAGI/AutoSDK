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
    public static class WebhooksIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhooksIssueAuthorAssociation.NONE => "NONE",
                WebhooksIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksIssueAuthorAssociation.MEMBER,
                "NONE" => WebhooksIssueAuthorAssociation.NONE,
                "OWNER" => WebhooksIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}