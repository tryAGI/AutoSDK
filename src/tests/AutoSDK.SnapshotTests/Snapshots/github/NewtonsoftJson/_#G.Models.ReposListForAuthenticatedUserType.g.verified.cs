//HintName: G.Models.ReposListForAuthenticatedUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForAuthenticatedUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
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