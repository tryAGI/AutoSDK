//HintName: G.Models.NonStreamingOutputFormats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NonStreamingOutputFormats
    {
        /// <summary>
        /// 
        /// </summary>
        Wav16000,
        /// <summary>
        /// 
        /// </summary>
        Wav22050,
        /// <summary>
        /// 
        /// </summary>
        Wav24000,
        /// <summary>
        /// 
        /// </summary>
        Wav32000,
        /// <summary>
        /// 
        /// </summary>
        Wav44100,
        /// <summary>
        /// 
        /// </summary>
        Wav48000,
        /// <summary>
        /// 
        /// </summary>
        Wav8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NonStreamingOutputFormatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NonStreamingOutputFormats value)
        {
            return value switch
            {
                NonStreamingOutputFormats.Wav16000 => "wav_16000",
                NonStreamingOutputFormats.Wav22050 => "wav_22050",
                NonStreamingOutputFormats.Wav24000 => "wav_24000",
                NonStreamingOutputFormats.Wav32000 => "wav_32000",
                NonStreamingOutputFormats.Wav44100 => "wav_44100",
                NonStreamingOutputFormats.Wav48000 => "wav_48000",
                NonStreamingOutputFormats.Wav8000 => "wav_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NonStreamingOutputFormats? ToEnum(string value)
        {
            return value switch
            {
                "wav_16000" => NonStreamingOutputFormats.Wav16000,
                "wav_22050" => NonStreamingOutputFormats.Wav22050,
                "wav_24000" => NonStreamingOutputFormats.Wav24000,
                "wav_32000" => NonStreamingOutputFormats.Wav32000,
                "wav_44100" => NonStreamingOutputFormats.Wav44100,
                "wav_48000" => NonStreamingOutputFormats.Wav48000,
                "wav_8000" => NonStreamingOutputFormats.Wav8000,
                _ => null,
            };
        }
    }
}