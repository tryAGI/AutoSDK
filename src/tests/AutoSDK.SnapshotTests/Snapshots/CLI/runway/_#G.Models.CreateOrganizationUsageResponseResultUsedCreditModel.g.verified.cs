//HintName: G.Models.CreateOrganizationUsageResponseResultUsedCreditModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model that credits were spent on.
    /// </summary>
    public enum CreateOrganizationUsageResponseResultUsedCreditModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gen3aTurbo,
        /// <summary>
        /// 
        /// </summary>
        Gen4Turbo,
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
        ActTwo,
        /// <summary>
        /// 
        /// </summary>
        Gen4Aleph,
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
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
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
        ElevenVoiceIsolation,
        /// <summary>
        /// 
        /// </summary>
        ElevenVoiceDubbing,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualStsV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationUsageResponseResultUsedCreditModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationUsageResponseResultUsedCreditModel value)
        {
            return value switch
            {
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo => "gen3a_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo => "gen4_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image => "gen4_image",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo => "gen4_image_turbo",
                CreateOrganizationUsageResponseResultUsedCreditModel.ActTwo => "act_two",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph => "gen4_aleph",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo3 => "veo3",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31 => "veo3.1",
                CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast => "veo3.1_fast",
                CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash => "gemini_2.5_flash",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationUsageResponseResultUsedCreditModel? ToEnum(string value)
        {
            return value switch
            {
                "gen3a_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen3aTurbo,
                "gen4_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Turbo,
                "gen4_image" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Image,
                "gen4_image_turbo" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4ImageTurbo,
                "act_two" => CreateOrganizationUsageResponseResultUsedCreditModel.ActTwo,
                "gen4_aleph" => CreateOrganizationUsageResponseResultUsedCreditModel.Gen4Aleph,
                "veo3" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo3,
                "veo3.1" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31,
                "veo3.1_fast" => CreateOrganizationUsageResponseResultUsedCreditModel.Veo31Fast,
                "gemini_2.5_flash" => CreateOrganizationUsageResponseResultUsedCreditModel.Gemini25Flash,
                "eleven_multilingual_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualV2,
                "eleven_text_to_sound_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenTextToSoundV2,
                "eleven_voice_isolation" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceIsolation,
                "eleven_voice_dubbing" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenVoiceDubbing,
                "eleven_multilingual_sts_v2" => CreateOrganizationUsageResponseResultUsedCreditModel.ElevenMultilingualStsV2,
                _ => null,
            };
        }
    }
}