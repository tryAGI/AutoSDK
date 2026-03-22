//HintName: G.Models.IssuesListForAuthenticatedUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForAuthenticatedUserSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comments")]
        Comments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForAuthenticatedUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForAuthenticatedUserSort value)
        {
            return value switch
            {
                IssuesListForAuthenticatedUserSort.Comments => "comments",
                IssuesListForAuthenticatedUserSort.Created => "created",
                IssuesListForAuthenticatedUserSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserSort? ToEnum(string value)
        {
            return value switch
            {
                "comments" => IssuesListForAuthenticatedUserSort.Comments,
                "created" => IssuesListForAuthenticatedUserSort.Created,
                "updated" => IssuesListForAuthenticatedUserSort.Updated,
                _ => null,
            };
        }
    }
}