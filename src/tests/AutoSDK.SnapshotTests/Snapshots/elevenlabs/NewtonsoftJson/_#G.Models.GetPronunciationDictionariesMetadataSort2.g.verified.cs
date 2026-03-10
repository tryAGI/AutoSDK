//HintName: G.Models.GetPronunciationDictionariesMetadataSort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPronunciationDictionariesMetadataSort2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creation_time_unix")]
        CreationTimeUnix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPronunciationDictionariesMetadataSort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPronunciationDictionariesMetadataSort2 value)
        {
            return value switch
            {
                GetPronunciationDictionariesMetadataSort2.CreationTimeUnix => "creation_time_unix",
                GetPronunciationDictionariesMetadataSort2.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPronunciationDictionariesMetadataSort2? ToEnum(string value)
        {
            return value switch
            {
                "creation_time_unix" => GetPronunciationDictionariesMetadataSort2.CreationTimeUnix,
                "name" => GetPronunciationDictionariesMetadataSort2.Name,
                _ => null,
            };
        }
    }
}