//HintName: G.Models.ActivityListReposStarredByUserDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ActivityListReposStarredByUserDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityListReposStarredByUserDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityListReposStarredByUserDirection value)
        {
            return value switch
            {
                ActivityListReposStarredByUserDirection.Asc => "asc",
                ActivityListReposStarredByUserDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityListReposStarredByUserDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => ActivityListReposStarredByUserDirection.Asc,
                "desc" => ActivityListReposStarredByUserDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}