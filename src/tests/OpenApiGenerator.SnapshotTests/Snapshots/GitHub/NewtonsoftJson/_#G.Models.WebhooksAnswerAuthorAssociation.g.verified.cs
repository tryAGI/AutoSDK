//HintName: G.Models.WebhooksAnswerAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksAnswerAuthorAssociation
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
    public static class WebhooksAnswerAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAnswerAuthorAssociation value)
        {
            return value switch
            {
                WebhooksAnswerAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksAnswerAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksAnswerAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksAnswerAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksAnswerAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksAnswerAuthorAssociation.MEMBER => "MEMBER",
                WebhooksAnswerAuthorAssociation.NONE => "NONE",
                WebhooksAnswerAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAnswerAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksAnswerAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksAnswerAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksAnswerAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksAnswerAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksAnswerAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksAnswerAuthorAssociation.MEMBER,
                "NONE" => WebhooksAnswerAuthorAssociation.NONE,
                "OWNER" => WebhooksAnswerAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}