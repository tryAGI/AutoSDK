//HintName: G.Models.StreamingTranscriptionResponseVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingTranscriptionResponseVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingTranscriptionResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingTranscriptionResponseVariant3Type value)
        {
            return value switch
            {
                StreamingTranscriptionResponseVariant3Type.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingTranscriptionResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "done" => StreamingTranscriptionResponseVariant3Type.Done,
                _ => null,
            };
        }
    }
}