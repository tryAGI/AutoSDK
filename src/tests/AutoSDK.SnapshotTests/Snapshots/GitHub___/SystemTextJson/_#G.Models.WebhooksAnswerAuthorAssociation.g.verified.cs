//HintName: G.Models.WebhooksAnswerAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksAnswerAuthorAssociation
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
        public static WebhooksAnswerAuthorAssociation? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}