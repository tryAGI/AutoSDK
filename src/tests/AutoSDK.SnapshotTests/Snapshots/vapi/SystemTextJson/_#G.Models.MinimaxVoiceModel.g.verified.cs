//HintName: G.Models.MinimaxVoiceModel.g.cs

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
    public enum MinimaxVoiceModel
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
    public static class MinimaxVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxVoiceModel value)
        {
            return value switch
            {
                MinimaxVoiceModel.Speech02Hd => "speech-02-hd",
                MinimaxVoiceModel.Speech02Turbo => "speech-02-turbo",
                MinimaxVoiceModel.Speech25TurboPreview => "speech-2.5-turbo-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "speech-02-hd" => MinimaxVoiceModel.Speech02Hd,
                "speech-02-turbo" => MinimaxVoiceModel.Speech02Turbo,
                "speech-2.5-turbo-preview" => MinimaxVoiceModel.Speech25TurboPreview,
                _ => null,
            };
        }
    }
}