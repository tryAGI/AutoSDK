//HintName: G.Models.TimestampGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The granularity of timestamps to include in the response.<br/>
    /// Currently only `word` level timestamps are supported, providing start and end times for each word.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TimestampGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimestampGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimestampGranularity value)
        {
            return value switch
            {
                TimestampGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimestampGranularity? ToEnum(string value)
        {
            return value switch
            {
                "word" => TimestampGranularity.Word,
                _ => null,
            };
        }
    }
}