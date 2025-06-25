//HintName: G.Models.FileSearchToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the file search tool call. Always `file_search_call`.
    /// </summary>
    public enum FileSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolCallType value)
        {
            return value switch
            {
                FileSearchToolCallType.FileSearchCall => "file_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call" => FileSearchToolCallType.FileSearchCall,
                _ => null,
            };
        }
    }
}