//HintName: G.Models.IssuesListCommentsForRepoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListCommentsForRepoDirection
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
    public static class IssuesListCommentsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListCommentsForRepoDirection value)
        {
            return value switch
            {
                IssuesListCommentsForRepoDirection.Asc => "asc",
                IssuesListCommentsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListCommentsForRepoDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => IssuesListCommentsForRepoDirection.Asc,
                "desc" => IssuesListCommentsForRepoDirection.Desc,
                _ => null,
            };
        }
    }
}