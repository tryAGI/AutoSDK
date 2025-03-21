//HintName: G.Models.FileSearchToolRankingOptionsRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranker to use for the file search.<br/>
    /// Default Value: auto
    /// </summary>
    public enum FileSearchToolRankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchToolRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolRankingOptionsRanker value)
        {
            return value switch
            {
                FileSearchToolRankingOptionsRanker.Auto => "auto",
                FileSearchToolRankingOptionsRanker.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FileSearchToolRankingOptionsRanker.Auto,
                "default-2024-11-15" => FileSearchToolRankingOptionsRanker.Default20241115,
                _ => null,
            };
        }
    }
}