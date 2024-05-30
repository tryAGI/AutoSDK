//HintName: G.Models.AssistantToolsFileSearchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `file_search`
    /// </summary>
    public enum AssistantToolsFileSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantToolsFileSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantToolsFileSearchType value)
        {
            return value switch
            {
                AssistantToolsFileSearchType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantToolsFileSearchType ToEnum(string value)
        {
            return value switch
            {
                "file_search" => AssistantToolsFileSearchType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}