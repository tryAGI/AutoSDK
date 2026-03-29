//HintName: G.Models.AgentRequestDenoisingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set, determines what denoising mode to use. Use "no-denoise" to bypass all audio denoising. Default to noise-cancellation.<br/>
    /// Example: noise-cancellation
    /// </summary>
    public enum AgentRequestDenoisingMode
    {
        /// <summary>
        /// 
        /// </summary>
        NoDenoise,
        /// <summary>
        /// 
        /// </summary>
        NoiseAndBackgroundSpeechCancellation,
        /// <summary>
        /// 
        /// </summary>
        NoiseCancellation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestDenoisingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestDenoisingMode value)
        {
            return value switch
            {
                AgentRequestDenoisingMode.NoDenoise => "no-denoise",
                AgentRequestDenoisingMode.NoiseAndBackgroundSpeechCancellation => "noise-and-background-speech-cancellation",
                AgentRequestDenoisingMode.NoiseCancellation => "noise-cancellation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestDenoisingMode? ToEnum(string value)
        {
            return value switch
            {
                "no-denoise" => AgentRequestDenoisingMode.NoDenoise,
                "noise-and-background-speech-cancellation" => AgentRequestDenoisingMode.NoiseAndBackgroundSpeechCancellation,
                "noise-cancellation" => AgentRequestDenoisingMode.NoiseCancellation,
                _ => null,
            };
        }
    }
}