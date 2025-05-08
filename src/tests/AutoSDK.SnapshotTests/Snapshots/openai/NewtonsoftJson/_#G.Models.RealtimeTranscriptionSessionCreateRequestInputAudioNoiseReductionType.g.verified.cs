//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="near_field")]
        NearField,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="far_field")]
        FarField,
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
                RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.NearField => "near_field",
                RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.FarField => "far_field",
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
                "near_field" => RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.NearField,
                "far_field" => RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}