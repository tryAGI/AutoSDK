//HintName: G.Models.GetJobsAlignmentTags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetJobsAlignmentTags
    {
        /// <summary>
        /// 00:00.4] `. The default is `word_start_and_end`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_per_line")]
        OnePerLine,
        /// <summary>
        /// 00:00.4] `. The default is `word_start_and_end`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word_start_and_end")]
        WordStartAndEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJobsAlignmentTagsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsAlignmentTags value)
        {
            return value switch
            {
                GetJobsAlignmentTags.OnePerLine => "one_per_line",
                GetJobsAlignmentTags.WordStartAndEnd => "word_start_and_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsAlignmentTags? ToEnum(string value)
        {
            return value switch
            {
                "one_per_line" => GetJobsAlignmentTags.OnePerLine,
                "word_start_and_end" => GetJobsAlignmentTags.WordStartAndEnd,
                _ => null,
            };
        }
    }
}