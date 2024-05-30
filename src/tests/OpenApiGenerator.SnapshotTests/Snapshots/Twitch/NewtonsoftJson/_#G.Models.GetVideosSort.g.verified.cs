//HintName: G.Models.GetVideosSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetVideosSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trending")]
        Trending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="views")]
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