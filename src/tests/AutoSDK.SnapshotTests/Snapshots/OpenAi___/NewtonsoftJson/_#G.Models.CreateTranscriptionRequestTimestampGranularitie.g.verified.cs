//HintName: G.Models.CreateTranscriptionRequestTimestampGranularitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranscriptionRequestTimestampGranularitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="segment")]
        Segment,
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
                CreateTranscriptionRequestTimestampGranularitie.Word => "word",
                CreateTranscriptionRequestTimestampGranularitie.Segment => "segment",
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
                "word" => CreateTranscriptionRequestTimestampGranularitie.Word,
                "segment" => CreateTranscriptionRequestTimestampGranularitie.Segment,
                _ => null,
            };
        }
    }
}