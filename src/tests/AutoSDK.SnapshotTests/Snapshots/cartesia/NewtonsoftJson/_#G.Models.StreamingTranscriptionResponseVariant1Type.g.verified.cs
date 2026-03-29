//HintName: G.Models.StreamingTranscriptionResponseVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingTranscriptionResponseVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingTranscriptionResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingTranscriptionResponseVariant1Type value)
        {
            return value switch
            {
                StreamingTranscriptionResponseVariant1Type.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingTranscriptionResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => StreamingTranscriptionResponseVariant1Type.Transcript,
                _ => null,
            };
        }
    }
}