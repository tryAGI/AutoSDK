//HintName: G.Models.FallbackMinimaxVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Options are 'speech-02-hd' and 'speech-02-turbo'.<br/>
    /// speech-02-hd is optimized for high-fidelity applications like voiceovers and audiobooks.<br/>
    /// speech-02-turbo is designed for real-time applications with low latency.<br/>
    /// @default "speech-02-turbo"<br/>
    /// Default Value: speech-02-turbo<br/>
    /// Example: speech-02-turbo
    /// </summary>
    public enum FallbackMinimaxVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Speech02Hd,
        /// <summary>
        /// 
        /// </summary>
        Speech02Turbo,
        /// <summary>
        /// 
        /// </summary>
        Speech25TurboPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMinimaxVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMinimaxVoiceModel value)
        {
            return value switch
            {
                FallbackMinimaxVoiceModel.Speech02Hd => "speech-02-hd",
                FallbackMinimaxVoiceModel.Speech02Turbo => "speech-02-turbo",
                FallbackMinimaxVoiceModel.Speech25TurboPreview => "speech-2.5-turbo-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMinimaxVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "speech-02-hd" => FallbackMinimaxVoiceModel.Speech02Hd,
                "speech-02-turbo" => FallbackMinimaxVoiceModel.Speech02Turbo,
                "speech-2.5-turbo-preview" => FallbackMinimaxVoiceModel.Speech25TurboPreview,
                _ => null,
            };
        }
    }
}