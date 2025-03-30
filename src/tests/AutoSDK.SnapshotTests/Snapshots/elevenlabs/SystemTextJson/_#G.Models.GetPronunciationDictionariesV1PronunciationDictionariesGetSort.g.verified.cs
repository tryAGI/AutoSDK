//HintName: G.Models.GetPronunciationDictionariesV1PronunciationDictionariesGetSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which field to sort by, one of 'created_at_unix' or 'name'.<br/>
    /// Default Value: creation_time_unix<br/>
    /// Example: creation_time_unix
    /// </summary>
    public enum GetPronunciationDictionariesV1PronunciationDictionariesGetSort
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
    public static class GetPronunciationDictionariesV1PronunciationDictionariesGetSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionariesV1PronunciationDictionariesGetSort value)
        {
            return value switch
            {
                GetPronunciationDictionariesV1PronunciationDictionariesGetSort.CreationTimeUnix => "creation_time_unix",
                GetPronunciationDictionariesV1PronunciationDictionariesGetSort.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionariesV1PronunciationDictionariesGetSort? ToEnum(string value)
        {
            return value switch
            {
                "creation_time_unix" => GetPronunciationDictionariesV1PronunciationDictionariesGetSort.CreationTimeUnix,
                "name" => GetPronunciationDictionariesV1PronunciationDictionariesGetSort.Name,
                _ => null,
            };
        }
    }
}