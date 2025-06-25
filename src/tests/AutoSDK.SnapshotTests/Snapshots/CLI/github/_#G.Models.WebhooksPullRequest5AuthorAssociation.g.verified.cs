//HintName: G.Models.WebhooksPullRequest5AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksPullRequest5AuthorAssociation
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
    public static class WebhooksPullRequest5AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AuthorAssociation value)
        {
            return value switch
            {
                WebhooksPullRequest5AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksPullRequest5AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksPullRequest5AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksPullRequest5AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksPullRequest5AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksPullRequest5AuthorAssociation.MEMBER => "MEMBER",
                WebhooksPullRequest5AuthorAssociation.NONE => "NONE",
                WebhooksPullRequest5AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksPullRequest5AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksPullRequest5AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksPullRequest5AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksPullRequest5AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksPullRequest5AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksPullRequest5AuthorAssociation.MEMBER,
                "NONE" => WebhooksPullRequest5AuthorAssociation.NONE,
                "OWNER" => WebhooksPullRequest5AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}