//HintName: G.Models.ReposListForAuthenticatedUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReposListForAuthenticatedUserType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForAuthenticatedUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForAuthenticatedUserType value)
        {
            return value switch
            {
                ReposListForAuthenticatedUserType.All => "all",
                ReposListForAuthenticatedUserType.Member => "member",
                ReposListForAuthenticatedUserType.Owner => "owner",
                ReposListForAuthenticatedUserType.Private => "private",
                ReposListForAuthenticatedUserType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForAuthenticatedUserType? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForAuthenticatedUserType.All,
                "member" => ReposListForAuthenticatedUserType.Member,
                "owner" => ReposListForAuthenticatedUserType.Owner,
                "private" => ReposListForAuthenticatedUserType.Private,
                "public" => ReposListForAuthenticatedUserType.Public,
                _ => null,
            };
        }
    }
}