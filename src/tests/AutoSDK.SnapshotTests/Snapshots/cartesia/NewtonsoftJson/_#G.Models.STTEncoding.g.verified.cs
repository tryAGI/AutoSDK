//HintName: G.Models.STTEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding format for audio data sent to the STT WebSocket.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum STTEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_alaw")]
        PcmAlaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_f16le")]
        PcmF16le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_f32le")]
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_mulaw")]
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le")]
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s32le")]
        PcmS32le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTEncoding value)
        {
            return value switch
            {
                STTEncoding.PcmAlaw => "pcm_alaw",
                STTEncoding.PcmF16le => "pcm_f16le",
                STTEncoding.PcmF32le => "pcm_f32le",
                STTEncoding.PcmMulaw => "pcm_mulaw",
                STTEncoding.PcmS16le => "pcm_s16le",
                STTEncoding.PcmS32le => "pcm_s32le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => STTEncoding.PcmAlaw,
                "pcm_f16le" => STTEncoding.PcmF16le,
                "pcm_f32le" => STTEncoding.PcmF32le,
                "pcm_mulaw" => STTEncoding.PcmMulaw,
                "pcm_s16le" => STTEncoding.PcmS16le,
                "pcm_s32le" => STTEncoding.PcmS32le,
                _ => null,
            };
        }
    }
}