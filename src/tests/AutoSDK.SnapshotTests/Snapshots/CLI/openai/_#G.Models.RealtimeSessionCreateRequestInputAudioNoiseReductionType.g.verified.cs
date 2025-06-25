//HintName: G.Models.RealtimeSessionCreateRequestInputAudioNoiseReductionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    public enum RealtimeSessionCreateRequestInputAudioNoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        NearField,
        /// <summary>
        /// 
        /// </summary>
        FarField,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestInputAudioNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestInputAudioNoiseReductionType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestInputAudioNoiseReductionType.NearField => "near_field",
                RealtimeSessionCreateRequestInputAudioNoiseReductionType.FarField => "far_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestInputAudioNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "near_field" => RealtimeSessionCreateRequestInputAudioNoiseReductionType.NearField,
                "far_field" => RealtimeSessionCreateRequestInputAudioNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}