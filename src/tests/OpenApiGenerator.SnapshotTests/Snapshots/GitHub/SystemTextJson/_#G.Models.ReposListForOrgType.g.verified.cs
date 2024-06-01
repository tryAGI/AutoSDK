//HintName: G.Models.ReposListForOrgType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    public enum ReposListForOrgType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Forks,
        /// <summary>
        /// 
        /// </summary>
        Sources,
        /// <summary>
        /// 
        /// </summary>
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