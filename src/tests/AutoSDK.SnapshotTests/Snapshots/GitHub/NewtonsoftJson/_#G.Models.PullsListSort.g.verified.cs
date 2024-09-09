//HintName: G.Models.PullsListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsListSort
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
        [global::System.Runtime.Serialization.EnumMember(Value="popularity")]
        Popularity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long-running")]
        LongRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListSort value)
        {
            return value switch
            {
                PullsListSort.Created => "created",
                PullsListSort.Updated => "updated",
                PullsListSort.Popularity => "popularity",
                PullsListSort.LongRunning => "long-running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => PullsListSort.Created,
                "updated" => PullsListSort.Updated,
                "popularity" => PullsListSort.Popularity,
                "long-running" => PullsListSort.LongRunning,
                _ => null,
            };
        }
    }
}