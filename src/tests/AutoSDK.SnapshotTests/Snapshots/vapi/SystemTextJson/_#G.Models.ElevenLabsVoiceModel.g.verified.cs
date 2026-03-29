//HintName: G.Models.ElevenLabsVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.<br/>
    /// Example: eleven_turbo_v2_5
    /// </summary>
    public enum ElevenLabsVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenFlashV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenFlashV25,
        /// <summary>
        /// 
        /// </summary>
        ElevenMonolingualV1,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
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
        ElevenV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsVoiceModel value)
        {
            return value switch
            {
                ElevenLabsVoiceModel.ElevenFlashV2 => "eleven_flash_v2",
                ElevenLabsVoiceModel.ElevenFlashV25 => "eleven_flash_v2_5",
                ElevenLabsVoiceModel.ElevenMonolingualV1 => "eleven_monolingual_v1",
                ElevenLabsVoiceModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                ElevenLabsVoiceModel.ElevenTurboV2 => "eleven_turbo_v2",
                ElevenLabsVoiceModel.ElevenTurboV25 => "eleven_turbo_v2_5",
                ElevenLabsVoiceModel.ElevenV3 => "eleven_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_flash_v2" => ElevenLabsVoiceModel.ElevenFlashV2,
                "eleven_flash_v2_5" => ElevenLabsVoiceModel.ElevenFlashV25,
                "eleven_monolingual_v1" => ElevenLabsVoiceModel.ElevenMonolingualV1,
                "eleven_multilingual_v2" => ElevenLabsVoiceModel.ElevenMultilingualV2,
                "eleven_turbo_v2" => ElevenLabsVoiceModel.ElevenTurboV2,
                "eleven_turbo_v2_5" => ElevenLabsVoiceModel.ElevenTurboV25,
                "eleven_v3" => ElevenLabsVoiceModel.ElevenV3,
                _ => null,
            };
        }
    }
}