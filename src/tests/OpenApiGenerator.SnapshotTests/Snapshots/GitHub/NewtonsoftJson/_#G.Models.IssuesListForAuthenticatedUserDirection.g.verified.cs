//HintName: G.Models.IssuesListForAuthenticatedUserDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForAuthenticatedUserDirection
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
    public static class IssuesListForAuthenticatedUserDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForAuthenticatedUserDirection value)
        {
            return value switch
            {
                IssuesListForAuthenticatedUserDirection.Asc => "asc",
                IssuesListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => IssuesListForAuthenticatedUserDirection.Asc,
                "desc" => IssuesListForAuthenticatedUserDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}