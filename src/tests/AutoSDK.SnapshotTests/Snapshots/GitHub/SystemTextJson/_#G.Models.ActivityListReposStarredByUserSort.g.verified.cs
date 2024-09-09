//HintName: G.Models.ActivityListReposStarredByUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum ActivityListReposStarredByUserSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityListReposStarredByUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityListReposStarredByUserSort value)
        {
            return value switch
            {
                ActivityListReposStarredByUserSort.Created => "created",
                ActivityListReposStarredByUserSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityListReposStarredByUserSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => ActivityListReposStarredByUserSort.Created,
                "updated" => ActivityListReposStarredByUserSort.Updated,
                _ => null,
            };
        }
    }
}