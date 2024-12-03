//HintName: G.Models.WebhookIssuesClosedIssueVariant1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1AuthorAssociation
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
    public static class WebhookIssuesClosedIssueVariant1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.NONE => "NONE",
                WebhookIssuesClosedIssueVariant1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesClosedIssueVariant1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesClosedIssueVariant1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesClosedIssueVariant1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesClosedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesClosedIssueVariant1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesClosedIssueVariant1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesClosedIssueVariant1AuthorAssociation.NONE,
                "OWNER" => WebhookIssuesClosedIssueVariant1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}