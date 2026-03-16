//HintName: G.Models.ResponseResultUsedCreditModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model that credits were spent on.
    /// </summary>
    public enum ResponseResultUsedCreditModel
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
    public static class ResponseResultUsedCreditModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResultUsedCreditModel value)
        {
            return value switch
            {
                ResponseResultUsedCreditModel.Gen3aTurbo => "gen3a_turbo",
                ResponseResultUsedCreditModel.Gen4Turbo => "gen4_turbo",
                ResponseResultUsedCreditModel.Gen4Image => "gen4_image",
                ResponseResultUsedCreditModel.Gen4ImageTurbo => "gen4_image_turbo",
                ResponseResultUsedCreditModel.ActTwo => "act_two",
                ResponseResultUsedCreditModel.Gen4Aleph => "gen4_aleph",
                ResponseResultUsedCreditModel.Veo3 => "veo3",
                ResponseResultUsedCreditModel.Veo31 => "veo3.1",
                ResponseResultUsedCreditModel.Veo31Fast => "veo3.1_fast",
                ResponseResultUsedCreditModel.Gemini25Flash => "gemini_2.5_flash",
                ResponseResultUsedCreditModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                ResponseResultUsedCreditModel.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                ResponseResultUsedCreditModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                ResponseResultUsedCreditModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                ResponseResultUsedCreditModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResultUsedCreditModel? ToEnum(string value)
        {
            return value switch
            {
                "gen3a_turbo" => ResponseResultUsedCreditModel.Gen3aTurbo,
                "gen4_turbo" => ResponseResultUsedCreditModel.Gen4Turbo,
                "gen4_image" => ResponseResultUsedCreditModel.Gen4Image,
                "gen4_image_turbo" => ResponseResultUsedCreditModel.Gen4ImageTurbo,
                "act_two" => ResponseResultUsedCreditModel.ActTwo,
                "gen4_aleph" => ResponseResultUsedCreditModel.Gen4Aleph,
                "veo3" => ResponseResultUsedCreditModel.Veo3,
                "veo3.1" => ResponseResultUsedCreditModel.Veo31,
                "veo3.1_fast" => ResponseResultUsedCreditModel.Veo31Fast,
                "gemini_2.5_flash" => ResponseResultUsedCreditModel.Gemini25Flash,
                "eleven_multilingual_v2" => ResponseResultUsedCreditModel.ElevenMultilingualV2,
                "eleven_text_to_sound_v2" => ResponseResultUsedCreditModel.ElevenTextToSoundV2,
                "eleven_voice_isolation" => ResponseResultUsedCreditModel.ElevenVoiceIsolation,
                "eleven_voice_dubbing" => ResponseResultUsedCreditModel.ElevenVoiceDubbing,
                "eleven_multilingual_sts_v2" => ResponseResultUsedCreditModel.ElevenMultilingualStsV2,
                _ => null,
            };
        }
    }
}