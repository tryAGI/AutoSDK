//HintName: G.Models.CreateOrganizationUsageResponseResultUsedCreditModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model that credits were spent on.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateOrganizationUsageResponseResultUsedCreditModel
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