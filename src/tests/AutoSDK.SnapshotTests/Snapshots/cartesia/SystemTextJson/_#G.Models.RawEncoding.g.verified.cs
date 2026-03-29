//HintName: G.Models.RawEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RawEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmAlaw,
        /// <summary>
        /// 
        /// </summary>
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RawEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RawEncoding value)
        {
            return value switch
            {
                RawEncoding.PcmAlaw => "pcm_alaw",
                RawEncoding.PcmF32le => "pcm_f32le",
                RawEncoding.PcmMulaw => "pcm_mulaw",
                RawEncoding.PcmS16le => "pcm_s16le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RawEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => RawEncoding.PcmAlaw,
                "pcm_f32le" => RawEncoding.PcmF32le,
                "pcm_mulaw" => RawEncoding.PcmMulaw,
                "pcm_s16le" => RawEncoding.PcmS16le,
                _ => null,
            };
        }
    }
}