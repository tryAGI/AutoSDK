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

    public static class GetVideosSortExtensions
    {
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
        public static GetVideosSort ToEnum(string value)
        {
            return value switch
            {
                "time" => GetVideosSort.Time,
                "trending" => GetVideosSort.Trending,
                "views" => GetVideosSort.Views,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosSort ToEnum(int value)
        {
            return value switch
            {
                0 => GetVideosSort.Time,
                1 => GetVideosSort.Trending,
                2 => GetVideosSort.Views,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}