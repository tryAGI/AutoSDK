//HintName: G.Models.ReposListForOrgType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
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
        [global::System.Runtime.Serialization.EnumMember(Value="forks")]
        Forks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sources")]
        Sources,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
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
                ReposListForOrgType.Public => "public",
                ReposListForOrgType.Private => "private",
                ReposListForOrgType.Forks => "forks",
                ReposListForOrgType.Sources => "sources",
                ReposListForOrgType.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForOrgType ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForOrgType.All,
                "public" => ReposListForOrgType.Public,
                "private" => ReposListForOrgType.Private,
                "forks" => ReposListForOrgType.Forks,
                "sources" => ReposListForOrgType.Sources,
                "member" => ReposListForOrgType.Member,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}