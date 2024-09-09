//HintName: G.Models.WebhooksPullRequest5AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
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