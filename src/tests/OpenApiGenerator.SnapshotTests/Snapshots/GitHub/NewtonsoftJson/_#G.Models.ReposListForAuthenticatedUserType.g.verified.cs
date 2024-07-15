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
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
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
                ReposListForAuthenticatedUserType.Owner => "owner",
                ReposListForAuthenticatedUserType.Public => "public",
                ReposListForAuthenticatedUserType.Private => "private",
                ReposListForAuthenticatedUserType.Member => "member",
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
                "owner" => ReposListForAuthenticatedUserType.Owner,
                "public" => ReposListForAuthenticatedUserType.Public,
                "private" => ReposListForAuthenticatedUserType.Private,
                "member" => ReposListForAuthenticatedUserType.Member,
                _ => null,
            };
        }
    }
}