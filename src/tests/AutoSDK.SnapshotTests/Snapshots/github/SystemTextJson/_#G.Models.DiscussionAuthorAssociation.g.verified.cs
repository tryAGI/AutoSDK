//HintName: G.Models.DiscussionAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum DiscussionAuthorAssociation
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
    public static class DiscussionAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionAuthorAssociation value)
        {
            return value switch
            {
                DiscussionAuthorAssociation.Collaborator => "COLLABORATOR",
                DiscussionAuthorAssociation.Contributor => "CONTRIBUTOR",
                DiscussionAuthorAssociation.FirstTimer => "FIRST_TIMER",
                DiscussionAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                DiscussionAuthorAssociation.Mannequin => "MANNEQUIN",
                DiscussionAuthorAssociation.Member => "MEMBER",
                DiscussionAuthorAssociation.None => "NONE",
                DiscussionAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => DiscussionAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => DiscussionAuthorAssociation.Contributor,
                "FIRST_TIMER" => DiscussionAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => DiscussionAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => DiscussionAuthorAssociation.Mannequin,
                "MEMBER" => DiscussionAuthorAssociation.Member,
                "NONE" => DiscussionAuthorAssociation.None,
                "OWNER" => DiscussionAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}