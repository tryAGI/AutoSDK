//HintName: G.Models.VoiceDesignRequestModelModelId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
    /// Default Value: eleven_multilingual_ttv_v2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceDesignRequestModelModelId
    {
        /// <summary>
        /// eleven_multilingual_ttv_v2, eleven_ttv_v3.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_ttv_v2")]
        ElevenMultilingualTtvV2,
        /// <summary>
        /// eleven_multilingual_ttv_v2, eleven_ttv_v3.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_ttv_v3")]
        ElevenTtvV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceDesignRequestModelModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceDesignRequestModelModelId value)
        {
            return value switch
            {
                VoiceDesignRequestModelModelId.ElevenMultilingualTtvV2 => "eleven_multilingual_ttv_v2",
                VoiceDesignRequestModelModelId.ElevenTtvV3 => "eleven_ttv_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceDesignRequestModelModelId? ToEnum(string value)
        {
            return value switch
            {
                "eleven_multilingual_ttv_v2" => VoiceDesignRequestModelModelId.ElevenMultilingualTtvV2,
                "eleven_ttv_v3" => VoiceDesignRequestModelModelId.ElevenTtvV3,
                _ => null,
            };
        }
    }
}