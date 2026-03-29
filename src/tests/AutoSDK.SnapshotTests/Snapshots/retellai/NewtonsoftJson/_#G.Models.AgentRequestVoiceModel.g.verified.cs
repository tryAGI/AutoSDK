//HintName: G.Models.AgentRequestVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select the voice model used for the selected voice. Each provider has a set of available voice models. Set to null to remove voice model selection, and default ones will apply. Check out dashboard for more details of each voice model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentRequestVoiceModel
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-tts")]
        Gpt4oMiniTts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s1")]
        S1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sonic-3")]
        Sonic3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sonic-3-latest")]
        Sonic3Latest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech-02-turbo")]
        Speech02Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech-2.8-turbo")]
        Speech28Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts-1")]
        Tts1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestVoiceModel value)
        {
            return value switch
            {
                AgentRequestVoiceModel.ElevenFlashV2 => "eleven_flash_v2",
                AgentRequestVoiceModel.ElevenFlashV25 => "eleven_flash_v2_5",
                AgentRequestVoiceModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                AgentRequestVoiceModel.ElevenTurboV2 => "eleven_turbo_v2",
                AgentRequestVoiceModel.ElevenTurboV25 => "eleven_turbo_v2_5",
                AgentRequestVoiceModel.ElevenV3 => "eleven_v3",
                AgentRequestVoiceModel.Gpt4oMiniTts => "gpt-4o-mini-tts",
                AgentRequestVoiceModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                AgentRequestVoiceModel.S1 => "s1",
                AgentRequestVoiceModel.Sonic3 => "sonic-3",
                AgentRequestVoiceModel.Sonic3Latest => "sonic-3-latest",
                AgentRequestVoiceModel.Speech02Turbo => "speech-02-turbo",
                AgentRequestVoiceModel.Speech28Turbo => "speech-2.8-turbo",
                AgentRequestVoiceModel.Tts1 => "tts-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_flash_v2" => AgentRequestVoiceModel.ElevenFlashV2,
                "eleven_flash_v2_5" => AgentRequestVoiceModel.ElevenFlashV25,
                "eleven_multilingual_v2" => AgentRequestVoiceModel.ElevenMultilingualV2,
                "eleven_turbo_v2" => AgentRequestVoiceModel.ElevenTurboV2,
                "eleven_turbo_v2_5" => AgentRequestVoiceModel.ElevenTurboV25,
                "eleven_v3" => AgentRequestVoiceModel.ElevenV3,
                "gpt-4o-mini-tts" => AgentRequestVoiceModel.Gpt4oMiniTts,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => AgentRequestVoiceModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "s1" => AgentRequestVoiceModel.S1,
                "sonic-3" => AgentRequestVoiceModel.Sonic3,
                "sonic-3-latest" => AgentRequestVoiceModel.Sonic3Latest,
                "speech-02-turbo" => AgentRequestVoiceModel.Speech02Turbo,
                "speech-2.8-turbo" => AgentRequestVoiceModel.Speech28Turbo,
                "tts-1" => AgentRequestVoiceModel.Tts1,
                _ => null,
            };
        }
    }
}