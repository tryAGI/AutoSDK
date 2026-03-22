//HintName: G.Models.RealtimeSessionCreateRequestInputAudioNoiseReductionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestInputAudioNoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="far_field")]
        FarField,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="near_field")]
        NearField,
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
                RealtimeSessionCreateRequestInputAudioNoiseReductionType.FarField => "far_field",
                RealtimeSessionCreateRequestInputAudioNoiseReductionType.NearField => "near_field",
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
                "far_field" => RealtimeSessionCreateRequestInputAudioNoiseReductionType.FarField,
                "near_field" => RealtimeSessionCreateRequestInputAudioNoiseReductionType.NearField,
                _ => null,
            };
        }
    }
}