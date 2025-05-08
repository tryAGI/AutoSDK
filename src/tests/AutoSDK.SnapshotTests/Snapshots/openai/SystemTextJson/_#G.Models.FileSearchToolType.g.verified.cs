//HintName: G.Models.FileSearchToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the file search tool. Always `file_search`.<br/>
    /// Default Value: file_search
    /// </summary>
    public enum FileSearchToolType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolType value)
        {
            return value switch
            {
                FileSearchToolType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => FileSearchToolType.FileSearch,
                _ => null,
            };
        }
    }
}