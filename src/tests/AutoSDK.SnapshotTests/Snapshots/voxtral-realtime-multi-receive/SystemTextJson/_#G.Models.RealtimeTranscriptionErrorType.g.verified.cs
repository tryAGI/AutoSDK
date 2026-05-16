//HintName: G.Models.RealtimeTranscriptionErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'error'.
    /// </summary>
    public enum RealtimeTranscriptionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionErrorType value)
        {
            return value switch
            {
                RealtimeTranscriptionErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeTranscriptionErrorType.Error,
                _ => null,
            };
        }
    }
}