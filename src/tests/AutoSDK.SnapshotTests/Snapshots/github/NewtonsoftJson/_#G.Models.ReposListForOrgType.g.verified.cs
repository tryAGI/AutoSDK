//HintName: G.Models.ReposListForOrgType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForOrgType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forks")]
        Forks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sources")]
        Sources,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForOrgTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForOrgType value)
        {
            return value switch
            {
                ReposListForOrgType.All => "all",
                ReposListForOrgType.Forks => "forks",
                ReposListForOrgType.Member => "member",
                ReposListForOrgType.Private => "private",
                ReposListForOrgType.Public => "public",
                ReposListForOrgType.Sources => "sources",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForOrgType? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForOrgType.All,
                "forks" => ReposListForOrgType.Forks,
                "member" => ReposListForOrgType.Member,
                "private" => ReposListForOrgType.Private,
                "public" => ReposListForOrgType.Public,
                "sources" => ReposListForOrgType.Sources,
                _ => null,
            };
        }
    }
}