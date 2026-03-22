//HintName: G.Models.CreateOrganizationUsageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that was used during the queried time range.
    /// </summary>
    public enum CreateOrganizationUsageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        ActTwo,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualStsV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTextToSoundV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenVoiceDubbing,
        /// <summary>
        /// 
        /// </summary>
        ElevenVoiceIsolation,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gen3aTurbo,
        /// <summary>
        /// 
        /// </summary>
        Gen4Aleph,
        /// <summary>
        /// 
        /// </summary>
        Gen4Image,
        /// <summary>
        /// 
        /// </summary>
        Gen4ImageTurbo,
        /// <summary>
        /// 
        /// </summary>
        Gen4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Veo3,
        /// <summary>
        /// 
        /// </summary>
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationUsageResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationUsageResponseModel value)
        {
            return value switch
            {
                CreateOrganizationUsageResponseModel.ActTwo => "act_two",
                CreateOrganizationUsageResponseModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                CreateOrganizationUsageResponseModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateOrganizationUsageResponseModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateOrganizationUsageResponseModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                CreateOrganizationUsageResponseModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                CreateOrganizationUsageResponseModel.Gemini25Flash => "gemini_2.5_flash",
                CreateOrganizationUsageResponseModel.Gen3aTurbo => "gen3a_turbo",
                CreateOrganizationUsageResponseModel.Gen4Aleph => "gen4_aleph",
                CreateOrganizationUsageResponseModel.Gen4Image => "gen4_image",
                CreateOrganizationUsageResponseModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateOrganizationUsageResponseModel.Gen4Turbo => "gen4_turbo",
                CreateOrganizationUsageResponseModel.Veo3 => "veo3",
                CreateOrganizationUsageResponseModel.Veo31 => "veo3.1",
                CreateOrganizationUsageResponseModel.Veo31Fast => "veo3.1_fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationUsageResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "act_two" => CreateOrganizationUsageResponseModel.ActTwo,
                "eleven_multilingual_sts_v2" => CreateOrganizationUsageResponseModel.ElevenMultilingualStsV2,
                "eleven_multilingual_v2" => CreateOrganizationUsageResponseModel.ElevenMultilingualV2,
                "eleven_text_to_sound_v2" => CreateOrganizationUsageResponseModel.ElevenTextToSoundV2,
                "eleven_voice_dubbing" => CreateOrganizationUsageResponseModel.ElevenVoiceDubbing,
                "eleven_voice_isolation" => CreateOrganizationUsageResponseModel.ElevenVoiceIsolation,
                "gemini_2.5_flash" => CreateOrganizationUsageResponseModel.Gemini25Flash,
                "gen3a_turbo" => CreateOrganizationUsageResponseModel.Gen3aTurbo,
                "gen4_aleph" => CreateOrganizationUsageResponseModel.Gen4Aleph,
                "gen4_image" => CreateOrganizationUsageResponseModel.Gen4Image,
                "gen4_image_turbo" => CreateOrganizationUsageResponseModel.Gen4ImageTurbo,
                "gen4_turbo" => CreateOrganizationUsageResponseModel.Gen4Turbo,
                "veo3" => CreateOrganizationUsageResponseModel.Veo3,
                "veo3.1" => CreateOrganizationUsageResponseModel.Veo31,
                "veo3.1_fast" => CreateOrganizationUsageResponseModel.Veo31Fast,
                _ => null,
            };
        }
    }
}