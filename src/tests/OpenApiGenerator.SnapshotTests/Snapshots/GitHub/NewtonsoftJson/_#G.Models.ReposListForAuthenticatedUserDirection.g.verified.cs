//HintName: G.Models.ReposListForAuthenticatedUserDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForAuthenticatedUserDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForAuthenticatedUserDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForAuthenticatedUserDirection value)
        {
            return value switch
            {
                ReposListForAuthenticatedUserDirection.Asc => "asc",
                ReposListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForAuthenticatedUserDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ReposListForAuthenticatedUserDirection.Asc,
                "desc" => ReposListForAuthenticatedUserDirection.Desc,
                _ => null,
            };
        }
    }
}