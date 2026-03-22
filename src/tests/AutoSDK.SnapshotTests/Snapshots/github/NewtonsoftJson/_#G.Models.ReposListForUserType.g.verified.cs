//HintName: G.Models.ReposListForUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: owner
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForUserType
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
                ReposListForUserType.Member => "member",
                ReposListForUserType.Owner => "owner",
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
                "member" => ReposListForUserType.Member,
                "owner" => ReposListForUserType.Owner,
                _ => null,
            };
        }
    }
}