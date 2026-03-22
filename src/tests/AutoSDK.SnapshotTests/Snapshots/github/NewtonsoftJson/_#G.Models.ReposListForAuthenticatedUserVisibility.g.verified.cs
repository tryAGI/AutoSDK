//HintName: G.Models.ReposListForAuthenticatedUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForAuthenticatedUserVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
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
    public static class ReposListForAuthenticatedUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForAuthenticatedUserVisibility value)
        {
            return value switch
            {
                ReposListForAuthenticatedUserVisibility.All => "all",
                ReposListForAuthenticatedUserVisibility.Private => "private",
                ReposListForAuthenticatedUserVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForAuthenticatedUserVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForAuthenticatedUserVisibility.All,
                "private" => ReposListForAuthenticatedUserVisibility.Private,
                "public" => ReposListForAuthenticatedUserVisibility.Public,
                _ => null,
            };
        }
    }
}