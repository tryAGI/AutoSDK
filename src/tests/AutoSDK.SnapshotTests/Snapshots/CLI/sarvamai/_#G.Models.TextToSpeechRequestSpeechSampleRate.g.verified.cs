//HintName: G.Models.TextToSpeechRequestSpeechSampleRate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio sample rate in Hz<br/>
    /// Default Value: 24000
    /// </summary>
    public enum TextToSpeechRequestSpeechSampleRate
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x22050,
        /// <summary>
        /// 
        /// </summary>
        x24000,
        /// <summary>
        /// 
        /// </summary>
        x32000,
        /// <summary>
        /// 
        /// </summary>
        x44100,
        /// <summary>
        /// 
        /// </summary>
        x48000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestSpeechSampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestSpeechSampleRate value)
        {
            return value switch
            {
                TextToSpeechRequestSpeechSampleRate.x16000 => "16000",
                TextToSpeechRequestSpeechSampleRate.x22050 => "22050",
                TextToSpeechRequestSpeechSampleRate.x24000 => "24000",
                TextToSpeechRequestSpeechSampleRate.x32000 => "32000",
                TextToSpeechRequestSpeechSampleRate.x44100 => "44100",
                TextToSpeechRequestSpeechSampleRate.x48000 => "48000",
                TextToSpeechRequestSpeechSampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestSpeechSampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => TextToSpeechRequestSpeechSampleRate.x16000,
                "22050" => TextToSpeechRequestSpeechSampleRate.x22050,
                "24000" => TextToSpeechRequestSpeechSampleRate.x24000,
                "32000" => TextToSpeechRequestSpeechSampleRate.x32000,
                "44100" => TextToSpeechRequestSpeechSampleRate.x44100,
                "48000" => TextToSpeechRequestSpeechSampleRate.x48000,
                "8000" => TextToSpeechRequestSpeechSampleRate.x8000,
                _ => null,
            };
        }
    }
}