//HintName: G.Models.FallbackElevenLabsVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'eleven_turbo_v2' if not specified.<br/>
    /// Example: eleven_turbo_v2_5
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackElevenLabsVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_flash_v2")]
        ElevenFlashV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_flash_v2_5")]
        ElevenFlashV25,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_monolingual_v1")]
        ElevenMonolingualV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_v2")]
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_turbo_v2")]
        ElevenTurboV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_turbo_v2_5")]
        ElevenTurboV25,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_v3")]
        ElevenV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsVoiceModel value)
        {
            return value switch
            {
                FallbackElevenLabsVoiceModel.ElevenFlashV2 => "eleven_flash_v2",
                FallbackElevenLabsVoiceModel.ElevenFlashV25 => "eleven_flash_v2_5",
                FallbackElevenLabsVoiceModel.ElevenMonolingualV1 => "eleven_monolingual_v1",
                FallbackElevenLabsVoiceModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                FallbackElevenLabsVoiceModel.ElevenTurboV2 => "eleven_turbo_v2",
                FallbackElevenLabsVoiceModel.ElevenTurboV25 => "eleven_turbo_v2_5",
                FallbackElevenLabsVoiceModel.ElevenV3 => "eleven_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_flash_v2" => FallbackElevenLabsVoiceModel.ElevenFlashV2,
                "eleven_flash_v2_5" => FallbackElevenLabsVoiceModel.ElevenFlashV25,
                "eleven_monolingual_v1" => FallbackElevenLabsVoiceModel.ElevenMonolingualV1,
                "eleven_multilingual_v2" => FallbackElevenLabsVoiceModel.ElevenMultilingualV2,
                "eleven_turbo_v2" => FallbackElevenLabsVoiceModel.ElevenTurboV2,
                "eleven_turbo_v2_5" => FallbackElevenLabsVoiceModel.ElevenTurboV25,
                "eleven_v3" => FallbackElevenLabsVoiceModel.ElevenV3,
                _ => null,
            };
        }
    }
}