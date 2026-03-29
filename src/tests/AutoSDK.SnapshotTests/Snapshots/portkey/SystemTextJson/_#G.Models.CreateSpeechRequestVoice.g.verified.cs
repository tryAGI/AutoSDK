//HintName: G.Models.CreateSpeechRequestVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice to use when generating the audio. Supported voices are `alloy`, `echo`, `fable`, `onyx`, `nova`, and `shimmer`. Previews of the voices are available in the [Text to speech guide](https://platform.openai.com/docs/guides/text-to-speech/voice-options).
    /// </summary>
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Alloy,
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Echo,
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Fable,
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Nova,
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Onyx,
        /// <summary>
        /// //platform.openai.com/docs/guides/text-to-speech/voice-options).
        /// </summary>
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestVoice value)
        {
            return value switch
            {
                CreateSpeechRequestVoice.Alloy => "alloy",
                CreateSpeechRequestVoice.Echo => "echo",
                CreateSpeechRequestVoice.Fable => "fable",
                CreateSpeechRequestVoice.Nova => "nova",
                CreateSpeechRequestVoice.Onyx => "onyx",
                CreateSpeechRequestVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => CreateSpeechRequestVoice.Alloy,
                "echo" => CreateSpeechRequestVoice.Echo,
                "fable" => CreateSpeechRequestVoice.Fable,
                "nova" => CreateSpeechRequestVoice.Nova,
                "onyx" => CreateSpeechRequestVoice.Onyx,
                "shimmer" => CreateSpeechRequestVoice.Shimmer,
                _ => null,
            };
        }
    }
}