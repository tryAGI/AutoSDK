//HintName: G.Models.GetVideosSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVideosSort
    {
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Trending,
        /// <summary>
        /// 
        /// </summary>
        Views,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideosSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideosSort value)
        {
            return value switch
            {
                GetVideosSort.Time => "time",
                GetVideosSort.Trending => "trending",
                GetVideosSort.Views => "views",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideosSort? ToEnum(string value)
        {
            return value switch
            {
                "time" => GetVideosSort.Time,
                "trending" => GetVideosSort.Trending,
                "views" => GetVideosSort.Views,
                _ => null,
            };
        }
    }
}