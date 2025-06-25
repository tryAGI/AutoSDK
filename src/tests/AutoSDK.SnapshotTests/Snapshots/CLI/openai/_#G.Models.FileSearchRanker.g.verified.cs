//HintName: G.Models.FileSearchRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranker to use for the file search. If not specified will use the `auto` ranker.
    /// </summary>
    public enum FileSearchRanker
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
    public static class FileSearchRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchRanker value)
        {
            return value switch
            {
                FileSearchRanker.Auto => "auto",
                FileSearchRanker.Default20240821 => "default_2024_08_21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FileSearchRanker.Auto,
                "default_2024_08_21" => FileSearchRanker.Default20240821,
                _ => null,
            };
        }
    }
}