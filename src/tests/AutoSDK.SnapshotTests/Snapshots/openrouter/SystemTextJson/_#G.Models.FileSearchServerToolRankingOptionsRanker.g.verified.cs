//HintName: G.Models.FileSearchServerToolRankingOptionsRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileSearchServerToolRankingOptionsRanker
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
    public static class FileSearchServerToolRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchServerToolRankingOptionsRanker value)
        {
            return value switch
            {
                FileSearchServerToolRankingOptionsRanker.Auto => "auto",
                FileSearchServerToolRankingOptionsRanker.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchServerToolRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FileSearchServerToolRankingOptionsRanker.Auto,
                "default-2024-11-15" => FileSearchServerToolRankingOptionsRanker.Default20241115,
                _ => null,
            };
        }
    }
}