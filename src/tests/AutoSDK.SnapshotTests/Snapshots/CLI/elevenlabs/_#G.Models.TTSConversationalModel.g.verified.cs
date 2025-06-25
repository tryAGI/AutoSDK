//HintName: G.Models.TTSConversationalModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSConversationalModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenTurboV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTurboV25,
        /// <summary>
        /// 
        /// </summary>
        ElevenFlashV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenFlashV25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSConversationalModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSConversationalModel value)
        {
            return value switch
            {
                TTSConversationalModel.ElevenTurboV2 => "eleven_turbo_v2",
                TTSConversationalModel.ElevenTurboV25 => "eleven_turbo_v2_5",
                TTSConversationalModel.ElevenFlashV2 => "eleven_flash_v2",
                TTSConversationalModel.ElevenFlashV25 => "eleven_flash_v2_5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSConversationalModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_turbo_v2" => TTSConversationalModel.ElevenTurboV2,
                "eleven_turbo_v2_5" => TTSConversationalModel.ElevenTurboV25,
                "eleven_flash_v2" => TTSConversationalModel.ElevenFlashV2,
                "eleven_flash_v2_5" => TTSConversationalModel.ElevenFlashV25,
                _ => null,
            };
        }
    }
}