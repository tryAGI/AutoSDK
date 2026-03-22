//HintName: G.Models.CreateTranscriptionRequestTimestampGranularitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionRequestTimestampGranularitie
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestTimestampGranularitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestTimestampGranularitie value)
        {
            return value switch
            {
                CreateTranscriptionRequestTimestampGranularitie.Segment => "segment",
                CreateTranscriptionRequestTimestampGranularitie.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestTimestampGranularitie? ToEnum(string value)
        {
            return value switch
            {
                "segment" => CreateTranscriptionRequestTimestampGranularitie.Segment,
                "word" => CreateTranscriptionRequestTimestampGranularitie.Word,
                _ => null,
            };
        }
    }
}