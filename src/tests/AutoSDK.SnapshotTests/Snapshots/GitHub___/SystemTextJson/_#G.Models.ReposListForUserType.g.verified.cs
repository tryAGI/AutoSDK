//HintName: G.Models.ReposListForUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: owner
    /// </summary>
    public enum ReposListForUserType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForUserType value)
        {
            return value switch
            {
                ReposListForUserType.All => "all",
                ReposListForUserType.Owner => "owner",
                ReposListForUserType.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForUserType? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForUserType.All,
                "owner" => ReposListForUserType.Owner,
                "member" => ReposListForUserType.Member,
                _ => null,
            };
        }
    }
}