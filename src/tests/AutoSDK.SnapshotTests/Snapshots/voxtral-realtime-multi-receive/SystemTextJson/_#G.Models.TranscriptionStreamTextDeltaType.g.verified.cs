//HintName: G.Models.TranscriptionStreamTextDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'transcription.text.delta'.
    /// </summary>
    public enum TranscriptionStreamTextDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamTextDeltaType value)
        {
            return value switch
            {
                TranscriptionStreamTextDeltaType.TranscriptionTextDelta => "transcription.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "transcription.text.delta" => TranscriptionStreamTextDeltaType.TranscriptionTextDelta,
                _ => null,
            };
        }
    }
}