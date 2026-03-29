//HintName: G.Models.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeminiMultimodalLivePrebuiltVoiceConfigVoiceName
    {
        /// <summary>
        /// 
        /// </summary>
        Aoede,
        /// <summary>
        /// 
        /// </summary>
        Charon,
        /// <summary>
        /// 
        /// </summary>
        Fenrir,
        /// <summary>
        /// 
        /// </summary>
        Kore,
        /// <summary>
        /// 
        /// </summary>
        Puck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiMultimodalLivePrebuiltVoiceConfigVoiceName value)
        {
            return value switch
            {
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede => "Aoede",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon => "Charon",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir => "Fenrir",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore => "Kore",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck => "Puck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiMultimodalLivePrebuiltVoiceConfigVoiceName? ToEnum(string value)
        {
            return value switch
            {
                "Aoede" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede,
                "Charon" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon,
                "Fenrir" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir,
                "Kore" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore,
                "Puck" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck,
                _ => null,
            };
        }
    }
}