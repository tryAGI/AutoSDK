//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        FarField,
        /// <summary>
        /// 
        /// </summary>
        NearField,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.FarField => "far_field",
                RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.NearField => "near_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "far_field" => RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.FarField,
                "near_field" => RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.NearField,
                _ => null,
            };
        }
    }
}