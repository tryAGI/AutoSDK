﻿//HintName: G.Models.SearchCodeSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchCodeSort
    {
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Indexed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCodeSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCodeSort value)
        {
            return value switch
            {
                SearchCodeSort.Indexed => "indexed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCodeSort? ToEnum(string value)
        {
            return value switch
            {
                "indexed" => SearchCodeSort.Indexed,
                _ => null,
            };
        }
    }
}