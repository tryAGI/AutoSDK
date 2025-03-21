//HintName: G.Models.CreateSpeechRequestVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice to use when generating the audio. Supported voices are `alloy`, `ash`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage` and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).
    /// </summary>
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Ash,
        /// <summary>
        /// 
        /// </summary>
        Coral,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Fable,
        /// <summary>
        /// 
        /// </summary>
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Sage,
        /// <summary>
        /// 
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
                CreateSpeechRequestVoice.Ash => "ash",
                CreateSpeechRequestVoice.Coral => "coral",
                CreateSpeechRequestVoice.Echo => "echo",
                CreateSpeechRequestVoice.Fable => "fable",
                CreateSpeechRequestVoice.Onyx => "onyx",
                CreateSpeechRequestVoice.Nova => "nova",
                CreateSpeechRequestVoice.Sage => "sage",
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
                "ash" => CreateSpeechRequestVoice.Ash,
                "coral" => CreateSpeechRequestVoice.Coral,
                "echo" => CreateSpeechRequestVoice.Echo,
                "fable" => CreateSpeechRequestVoice.Fable,
                "onyx" => CreateSpeechRequestVoice.Onyx,
                "nova" => CreateSpeechRequestVoice.Nova,
                "sage" => CreateSpeechRequestVoice.Sage,
                "shimmer" => CreateSpeechRequestVoice.Shimmer,
                _ => null,
            };
        }
    }
}