//HintName: G.Models.FallbackInworldVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.<br/>
    /// Default Value: inworld-tts-1
    /// </summary>
    public enum FallbackInworldVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        InworldTts1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackInworldVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackInworldVoiceModel value)
        {
            return value switch
            {
                FallbackInworldVoiceModel.InworldTts1 => "inworld-tts-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackInworldVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "inworld-tts-1" => FallbackInworldVoiceModel.InworldTts1,
                _ => null,
            };
        }
    }
}