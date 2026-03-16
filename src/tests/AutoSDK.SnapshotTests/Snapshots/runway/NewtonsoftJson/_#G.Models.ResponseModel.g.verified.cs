//HintName: G.Models.ResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that was used during the queried time range.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen3a_turbo")]
        Gen3aTurbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_turbo")]
        Gen4Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_image")]
        Gen4Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_image_turbo")]
        Gen4ImageTurbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="act_two")]
        ActTwo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_aleph")]
        Gen4Aleph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3")]
        Veo3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3.1")]
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3.1_fast")]
        Veo31Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini_2.5_flash")]
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_v2")]
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_text_to_sound_v2")]
        ElevenTextToSoundV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_voice_isolation")]
        ElevenVoiceIsolation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_voice_dubbing")]
        ElevenVoiceDubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_sts_v2")]
        ElevenMultilingualStsV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseModel value)
        {
            return value switch
            {
                ResponseModel.Gen3aTurbo => "gen3a_turbo",
                ResponseModel.Gen4Turbo => "gen4_turbo",
                ResponseModel.Gen4Image => "gen4_image",
                ResponseModel.Gen4ImageTurbo => "gen4_image_turbo",
                ResponseModel.ActTwo => "act_two",
                ResponseModel.Gen4Aleph => "gen4_aleph",
                ResponseModel.Veo3 => "veo3",
                ResponseModel.Veo31 => "veo3.1",
                ResponseModel.Veo31Fast => "veo3.1_fast",
                ResponseModel.Gemini25Flash => "gemini_2.5_flash",
                ResponseModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                ResponseModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                ResponseModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                ResponseModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                ResponseModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "gen3a_turbo" => ResponseModel.Gen3aTurbo,
                "gen4_turbo" => ResponseModel.Gen4Turbo,
                "gen4_image" => ResponseModel.Gen4Image,
                "gen4_image_turbo" => ResponseModel.Gen4ImageTurbo,
                "act_two" => ResponseModel.ActTwo,
                "gen4_aleph" => ResponseModel.Gen4Aleph,
                "veo3" => ResponseModel.Veo3,
                "veo3.1" => ResponseModel.Veo31,
                "veo3.1_fast" => ResponseModel.Veo31Fast,
                "gemini_2.5_flash" => ResponseModel.Gemini25Flash,
                "eleven_multilingual_v2" => ResponseModel.ElevenMultilingualV2,
                "eleven_text_to_sound_v2" => ResponseModel.ElevenTextToSoundV2,
                "eleven_voice_isolation" => ResponseModel.ElevenVoiceIsolation,
                "eleven_voice_dubbing" => ResponseModel.ElevenVoiceDubbing,
                "eleven_multilingual_sts_v2" => ResponseModel.ElevenMultilingualStsV2,
                _ => null,
            };
        }
    }
}