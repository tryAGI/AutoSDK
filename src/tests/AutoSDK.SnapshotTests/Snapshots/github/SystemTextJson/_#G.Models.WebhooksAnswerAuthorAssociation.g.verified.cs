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
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Owner,
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
                WebhooksAnswerAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksAnswerAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksAnswerAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksAnswerAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksAnswerAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksAnswerAuthorAssociation.Member => "MEMBER",
                WebhooksAnswerAuthorAssociation.None => "NONE",
                WebhooksAnswerAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhooksAnswerAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksAnswerAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksAnswerAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksAnswerAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksAnswerAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksAnswerAuthorAssociation.Member,
                "NONE" => WebhooksAnswerAuthorAssociation.None,
                "OWNER" => WebhooksAnswerAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}