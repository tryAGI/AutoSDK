//HintName: G.Models.FileSearchRankingOptionsRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranker to use for the file search. If not specified will use the `auto` ranker.
    /// </summary>
    public enum FileSearchRankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default20240821,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchRankingOptionsRanker value)
        {
            return value switch
            {
                FileSearchRankingOptionsRanker.Auto => "auto",
                FileSearchRankingOptionsRanker.Default20240821 => "default_2024_08_21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FileSearchRankingOptionsRanker.Auto,
                "default_2024_08_21" => FileSearchRankingOptionsRanker.Default20240821,
                _ => null,
            };
        }
    }
}