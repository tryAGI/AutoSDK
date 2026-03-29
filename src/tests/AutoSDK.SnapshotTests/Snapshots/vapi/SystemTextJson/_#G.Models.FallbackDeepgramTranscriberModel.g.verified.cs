//HintName: G.Models.FallbackDeepgramTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackDeepgramTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        BaseConversationalai,
        /// <summary>
        /// 
        /// </summary>
        BaseFinance,
        /// <summary>
        /// 
        /// </summary>
        BaseGeneral,
        /// <summary>
        /// 
        /// </summary>
        BaseMeeting,
        /// <summary>
        /// 
        /// </summary>
        BasePhonecall,
        /// <summary>
        /// 
        /// </summary>
        BaseVideo,
        /// <summary>
        /// 
        /// </summary>
        BaseVoicemail,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        EnhancedFinance,
        /// <summary>
        /// 
        /// </summary>
        EnhancedGeneral,
        /// <summary>
        /// 
        /// </summary>
        EnhancedMeeting,
        /// <summary>
        /// 
        /// </summary>
        EnhancedPhonecall,
        /// <summary>
        /// 
        /// </summary>
        FluxGeneralEn,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Nova2,
        /// <summary>
        /// 
        /// </summary>
        Nova2Automotive,
        /// <summary>
        /// 
        /// </summary>
        Nova2Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        Nova2Drivethru,
        /// <summary>
        /// 
        /// </summary>
        Nova2Finance,
        /// <summary>
        /// 
        /// </summary>
        Nova2General,
        /// <summary>
        /// 
        /// </summary>
        Nova2Medical,
        /// <summary>
        /// 
        /// </summary>
        Nova2Meeting,
        /// <summary>
        /// 
        /// </summary>
        Nova2Phonecall,
        /// <summary>
        /// 
        /// </summary>
        Nova2Video,
        /// <summary>
        /// 
        /// </summary>
        Nova2Voicemail,
        /// <summary>
        /// 
        /// </summary>
        Nova3,
        /// <summary>
        /// 
        /// </summary>
        Nova3General,
        /// <summary>
        /// 
        /// </summary>
        Nova3Medical,
        /// <summary>
        /// 
        /// </summary>
        NovaGeneral,
        /// <summary>
        /// 
        /// </summary>
        NovaMedical,
        /// <summary>
        /// 
        /// </summary>
        NovaPhonecall,
        /// <summary>
        /// 
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackDeepgramTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackDeepgramTranscriberModel value)
        {
            return value switch
            {
                FallbackDeepgramTranscriberModel.Base => "base",
                FallbackDeepgramTranscriberModel.BaseConversationalai => "base-conversationalai",
                FallbackDeepgramTranscriberModel.BaseFinance => "base-finance",
                FallbackDeepgramTranscriberModel.BaseGeneral => "base-general",
                FallbackDeepgramTranscriberModel.BaseMeeting => "base-meeting",
                FallbackDeepgramTranscriberModel.BasePhonecall => "base-phonecall",
                FallbackDeepgramTranscriberModel.BaseVideo => "base-video",
                FallbackDeepgramTranscriberModel.BaseVoicemail => "base-voicemail",
                FallbackDeepgramTranscriberModel.Enhanced => "enhanced",
                FallbackDeepgramTranscriberModel.EnhancedFinance => "enhanced-finance",
                FallbackDeepgramTranscriberModel.EnhancedGeneral => "enhanced-general",
                FallbackDeepgramTranscriberModel.EnhancedMeeting => "enhanced-meeting",
                FallbackDeepgramTranscriberModel.EnhancedPhonecall => "enhanced-phonecall",
                FallbackDeepgramTranscriberModel.FluxGeneralEn => "flux-general-en",
                FallbackDeepgramTranscriberModel.Nova => "nova",
                FallbackDeepgramTranscriberModel.Nova2 => "nova-2",
                FallbackDeepgramTranscriberModel.Nova2Automotive => "nova-2-automotive",
                FallbackDeepgramTranscriberModel.Nova2Conversationalai => "nova-2-conversationalai",
                FallbackDeepgramTranscriberModel.Nova2Drivethru => "nova-2-drivethru",
                FallbackDeepgramTranscriberModel.Nova2Finance => "nova-2-finance",
                FallbackDeepgramTranscriberModel.Nova2General => "nova-2-general",
                FallbackDeepgramTranscriberModel.Nova2Medical => "nova-2-medical",
                FallbackDeepgramTranscriberModel.Nova2Meeting => "nova-2-meeting",
                FallbackDeepgramTranscriberModel.Nova2Phonecall => "nova-2-phonecall",
                FallbackDeepgramTranscriberModel.Nova2Video => "nova-2-video",
                FallbackDeepgramTranscriberModel.Nova2Voicemail => "nova-2-voicemail",
                FallbackDeepgramTranscriberModel.Nova3 => "nova-3",
                FallbackDeepgramTranscriberModel.Nova3General => "nova-3-general",
                FallbackDeepgramTranscriberModel.Nova3Medical => "nova-3-medical",
                FallbackDeepgramTranscriberModel.NovaGeneral => "nova-general",
                FallbackDeepgramTranscriberModel.NovaMedical => "nova-medical",
                FallbackDeepgramTranscriberModel.NovaPhonecall => "nova-phonecall",
                FallbackDeepgramTranscriberModel.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackDeepgramTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "base" => FallbackDeepgramTranscriberModel.Base,
                "base-conversationalai" => FallbackDeepgramTranscriberModel.BaseConversationalai,
                "base-finance" => FallbackDeepgramTranscriberModel.BaseFinance,
                "base-general" => FallbackDeepgramTranscriberModel.BaseGeneral,
                "base-meeting" => FallbackDeepgramTranscriberModel.BaseMeeting,
                "base-phonecall" => FallbackDeepgramTranscriberModel.BasePhonecall,
                "base-video" => FallbackDeepgramTranscriberModel.BaseVideo,
                "base-voicemail" => FallbackDeepgramTranscriberModel.BaseVoicemail,
                "enhanced" => FallbackDeepgramTranscriberModel.Enhanced,
                "enhanced-finance" => FallbackDeepgramTranscriberModel.EnhancedFinance,
                "enhanced-general" => FallbackDeepgramTranscriberModel.EnhancedGeneral,
                "enhanced-meeting" => FallbackDeepgramTranscriberModel.EnhancedMeeting,
                "enhanced-phonecall" => FallbackDeepgramTranscriberModel.EnhancedPhonecall,
                "flux-general-en" => FallbackDeepgramTranscriberModel.FluxGeneralEn,
                "nova" => FallbackDeepgramTranscriberModel.Nova,
                "nova-2" => FallbackDeepgramTranscriberModel.Nova2,
                "nova-2-automotive" => FallbackDeepgramTranscriberModel.Nova2Automotive,
                "nova-2-conversationalai" => FallbackDeepgramTranscriberModel.Nova2Conversationalai,
                "nova-2-drivethru" => FallbackDeepgramTranscriberModel.Nova2Drivethru,
                "nova-2-finance" => FallbackDeepgramTranscriberModel.Nova2Finance,
                "nova-2-general" => FallbackDeepgramTranscriberModel.Nova2General,
                "nova-2-medical" => FallbackDeepgramTranscriberModel.Nova2Medical,
                "nova-2-meeting" => FallbackDeepgramTranscriberModel.Nova2Meeting,
                "nova-2-phonecall" => FallbackDeepgramTranscriberModel.Nova2Phonecall,
                "nova-2-video" => FallbackDeepgramTranscriberModel.Nova2Video,
                "nova-2-voicemail" => FallbackDeepgramTranscriberModel.Nova2Voicemail,
                "nova-3" => FallbackDeepgramTranscriberModel.Nova3,
                "nova-3-general" => FallbackDeepgramTranscriberModel.Nova3General,
                "nova-3-medical" => FallbackDeepgramTranscriberModel.Nova3Medical,
                "nova-general" => FallbackDeepgramTranscriberModel.NovaGeneral,
                "nova-medical" => FallbackDeepgramTranscriberModel.NovaMedical,
                "nova-phonecall" => FallbackDeepgramTranscriberModel.NovaPhonecall,
                "whisper" => FallbackDeepgramTranscriberModel.Whisper,
                _ => null,
            };
        }
    }
}