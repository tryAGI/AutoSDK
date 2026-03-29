//HintName: G.Models.SearchArchivalMemoryTagMatchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
    /// Default Value: any
    /// </summary>
    public enum SearchArchivalMemoryTagMatchMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchArchivalMemoryTagMatchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchArchivalMemoryTagMatchMode value)
        {
            return value switch
            {
                SearchArchivalMemoryTagMatchMode.All => "all",
                SearchArchivalMemoryTagMatchMode.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchArchivalMemoryTagMatchMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => SearchArchivalMemoryTagMatchMode.All,
                "any" => SearchArchivalMemoryTagMatchMode.Any,
                _ => null,
            };
        }
    }
}