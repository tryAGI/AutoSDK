//HintName: G.Models.GetVideosType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVideosType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Archive,
        /// <summary>
        /// 
        /// </summary>
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    public static class GetVideosTypeExtensions
    {
        public static string ToValueString(this GetVideosType value)
        {
            return value switch
            {
                GetVideosType.All => "all",
                GetVideosType.Archive => "archive",
                GetVideosType.Highlight => "highlight",
                GetVideosType.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosType ToEnum(string value)
        {
            return value switch
            {
                "all" => GetVideosType.All,
                "archive" => GetVideosType.Archive,
                "highlight" => GetVideosType.Highlight,
                "upload" => GetVideosType.Upload,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosType ToEnum(int value)
        {
            return value switch
            {
                0 => GetVideosType.All,
                1 => GetVideosType.Archive,
                2 => GetVideosType.Highlight,
                3 => GetVideosType.Upload,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}