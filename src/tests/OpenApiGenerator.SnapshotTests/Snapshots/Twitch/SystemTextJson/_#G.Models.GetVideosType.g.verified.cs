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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideosTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
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
    }
}