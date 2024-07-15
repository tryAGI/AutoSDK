//HintName: G.Models.WebhooksIssueCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueCommentAuthorAssociation
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
    public static class WebhooksIssueCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksIssueCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksIssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksIssueCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhooksIssueCommentAuthorAssociation.NONE => "NONE",
                WebhooksIssueCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksIssueCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksIssueCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksIssueCommentAuthorAssociation.MEMBER,
                "NONE" => WebhooksIssueCommentAuthorAssociation.NONE,
                "OWNER" => WebhooksIssueCommentAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}