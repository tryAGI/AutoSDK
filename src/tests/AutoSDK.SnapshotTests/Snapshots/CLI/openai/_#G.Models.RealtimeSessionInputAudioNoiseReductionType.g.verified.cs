//HintName: G.Models.RealtimeSessionInputAudioNoiseReductionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    public enum RealtimeSessionInputAudioNoiseReductionType
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
    public static class RealtimeSessionInputAudioNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionInputAudioNoiseReductionType value)
        {
            return value switch
            {
                RealtimeSessionInputAudioNoiseReductionType.NearField => "near_field",
                RealtimeSessionInputAudioNoiseReductionType.FarField => "far_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionInputAudioNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "near_field" => RealtimeSessionInputAudioNoiseReductionType.NearField,
                "far_field" => RealtimeSessionInputAudioNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}