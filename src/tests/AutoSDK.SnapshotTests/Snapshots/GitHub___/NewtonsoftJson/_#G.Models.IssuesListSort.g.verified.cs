//HintName: G.Models.IssuesListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListSort
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comments")]
        Comments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListSort value)
        {
            return value switch
            {
                IssuesListSort.Created => "created",
                IssuesListSort.Updated => "updated",
                IssuesListSort.Comments => "comments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => IssuesListSort.Created,
                "updated" => IssuesListSort.Updated,
                "comments" => IssuesListSort.Comments,
                _ => null,
            };
        }
    }
}