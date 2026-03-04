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
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        Owner,
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
                WebhooksPullRequest5AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksPullRequest5AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksPullRequest5AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksPullRequest5AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksPullRequest5AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksPullRequest5AuthorAssociation.Member => "MEMBER",
                WebhooksPullRequest5AuthorAssociation.None => "NONE",
                WebhooksPullRequest5AuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhooksPullRequest5AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksPullRequest5AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksPullRequest5AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksPullRequest5AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksPullRequest5AuthorAssociation.Mannequin,
                "MEMBER" => WebhooksPullRequest5AuthorAssociation.Member,
                "NONE" => WebhooksPullRequest5AuthorAssociation.None,
                "OWNER" => WebhooksPullRequest5AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}