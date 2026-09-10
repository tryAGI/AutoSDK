//HintName: G.Models.GetPronunciationDictionariesMetadataSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPronunciationDictionariesMetadataSort
    {
        /// <summary>
        /// 
        /// </summary>
        CreationTimeUnix,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPronunciationDictionariesMetadataSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionariesMetadataSort value)
        {
            return value switch
            {
                GetPronunciationDictionariesMetadataSort.CreationTimeUnix => "creation_time_unix",
                GetPronunciationDictionariesMetadataSort.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionariesMetadataSort? ToEnum(string value)
        {
            return value switch
            {
                "creation_time_unix" => GetPronunciationDictionariesMetadataSort.CreationTimeUnix,
                "name" => GetPronunciationDictionariesMetadataSort.Name,
                _ => null,
            };
        }
    }
}