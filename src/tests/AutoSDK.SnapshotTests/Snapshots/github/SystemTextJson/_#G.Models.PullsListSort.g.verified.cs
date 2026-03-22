//HintName: G.Models.PullsListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum PullsListSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        LongRunning,
        /// <summary>
        /// 
        /// </summary>
        Popularity,
        /// <summary>
        /// 
        /// </summary>
        Updated,
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
                PullsListSort.LongRunning => "long-running",
                PullsListSort.Popularity => "popularity",
                PullsListSort.Updated => "updated",
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
                "long-running" => PullsListSort.LongRunning,
                "popularity" => PullsListSort.Popularity,
                "updated" => PullsListSort.Updated,
                _ => null,
            };
        }
    }
}