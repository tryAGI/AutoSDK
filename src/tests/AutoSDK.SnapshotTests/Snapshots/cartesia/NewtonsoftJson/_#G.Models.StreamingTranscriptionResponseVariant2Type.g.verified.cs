//HintName: G.Models.StreamingTranscriptionResponseVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingTranscriptionResponseVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flush_done")]
        FlushDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingTranscriptionResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingTranscriptionResponseVariant2Type value)
        {
            return value switch
            {
                StreamingTranscriptionResponseVariant2Type.FlushDone => "flush_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingTranscriptionResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "flush_done" => StreamingTranscriptionResponseVariant2Type.FlushDone,
                _ => null,
            };
        }
    }
}