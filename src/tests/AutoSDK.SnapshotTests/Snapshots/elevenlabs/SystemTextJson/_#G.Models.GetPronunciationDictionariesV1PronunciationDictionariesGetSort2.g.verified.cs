//HintName: G.Models.GetPronunciationDictionariesV1PronunciationDictionariesGetSort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPronunciationDictionariesV1PronunciationDictionariesGetSort2
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
    public static class GetPronunciationDictionariesV1PronunciationDictionariesGetSort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionariesV1PronunciationDictionariesGetSort2 value)
        {
            return value switch
            {
                GetPronunciationDictionariesV1PronunciationDictionariesGetSort2.CreationTimeUnix => "creation_time_unix",
                GetPronunciationDictionariesV1PronunciationDictionariesGetSort2.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionariesV1PronunciationDictionariesGetSort2? ToEnum(string value)
        {
            return value switch
            {
                "creation_time_unix" => GetPronunciationDictionariesV1PronunciationDictionariesGetSort2.CreationTimeUnix,
                "name" => GetPronunciationDictionariesV1PronunciationDictionariesGetSort2.Name,
                _ => null,
            };
        }
    }
}