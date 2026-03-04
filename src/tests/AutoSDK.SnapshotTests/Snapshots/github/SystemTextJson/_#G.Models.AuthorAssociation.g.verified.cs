//HintName: G.Models.AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.<br/>
    /// Example: OWNER
    /// </summary>
    public enum AuthorAssociation
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
    public static class AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorAssociation value)
        {
            return value switch
            {
                AuthorAssociation.Collaborator => "COLLABORATOR",
                AuthorAssociation.Contributor => "CONTRIBUTOR",
                AuthorAssociation.FirstTimer => "FIRST_TIMER",
                AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                AuthorAssociation.Mannequin => "MANNEQUIN",
                AuthorAssociation.Member => "MEMBER",
                AuthorAssociation.None => "NONE",
                AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => AuthorAssociation.Contributor,
                "FIRST_TIMER" => AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => AuthorAssociation.Mannequin,
                "MEMBER" => AuthorAssociation.Member,
                "NONE" => AuthorAssociation.None,
                "OWNER" => AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}