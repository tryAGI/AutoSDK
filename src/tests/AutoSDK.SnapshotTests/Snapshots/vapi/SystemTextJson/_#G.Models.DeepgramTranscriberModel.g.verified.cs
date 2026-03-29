//HintName: G.Models.DeepgramTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeepgramTranscriberModel
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
    public static class DeepgramTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramTranscriberModel value)
        {
            return value switch
            {
                DeepgramTranscriberModel.Base => "base",
                DeepgramTranscriberModel.BaseConversationalai => "base-conversationalai",
                DeepgramTranscriberModel.BaseFinance => "base-finance",
                DeepgramTranscriberModel.BaseGeneral => "base-general",
                DeepgramTranscriberModel.BaseMeeting => "base-meeting",
                DeepgramTranscriberModel.BasePhonecall => "base-phonecall",
                DeepgramTranscriberModel.BaseVideo => "base-video",
                DeepgramTranscriberModel.BaseVoicemail => "base-voicemail",
                DeepgramTranscriberModel.Enhanced => "enhanced",
                DeepgramTranscriberModel.EnhancedFinance => "enhanced-finance",
                DeepgramTranscriberModel.EnhancedGeneral => "enhanced-general",
                DeepgramTranscriberModel.EnhancedMeeting => "enhanced-meeting",
                DeepgramTranscriberModel.EnhancedPhonecall => "enhanced-phonecall",
                DeepgramTranscriberModel.FluxGeneralEn => "flux-general-en",
                DeepgramTranscriberModel.Nova => "nova",
                DeepgramTranscriberModel.Nova2 => "nova-2",
                DeepgramTranscriberModel.Nova2Automotive => "nova-2-automotive",
                DeepgramTranscriberModel.Nova2Conversationalai => "nova-2-conversationalai",
                DeepgramTranscriberModel.Nova2Drivethru => "nova-2-drivethru",
                DeepgramTranscriberModel.Nova2Finance => "nova-2-finance",
                DeepgramTranscriberModel.Nova2General => "nova-2-general",
                DeepgramTranscriberModel.Nova2Medical => "nova-2-medical",
                DeepgramTranscriberModel.Nova2Meeting => "nova-2-meeting",
                DeepgramTranscriberModel.Nova2Phonecall => "nova-2-phonecall",
                DeepgramTranscriberModel.Nova2Video => "nova-2-video",
                DeepgramTranscriberModel.Nova2Voicemail => "nova-2-voicemail",
                DeepgramTranscriberModel.Nova3 => "nova-3",
                DeepgramTranscriberModel.Nova3General => "nova-3-general",
                DeepgramTranscriberModel.Nova3Medical => "nova-3-medical",
                DeepgramTranscriberModel.NovaGeneral => "nova-general",
                DeepgramTranscriberModel.NovaMedical => "nova-medical",
                DeepgramTranscriberModel.NovaPhonecall => "nova-phonecall",
                DeepgramTranscriberModel.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "base" => DeepgramTranscriberModel.Base,
                "base-conversationalai" => DeepgramTranscriberModel.BaseConversationalai,
                "base-finance" => DeepgramTranscriberModel.BaseFinance,
                "base-general" => DeepgramTranscriberModel.BaseGeneral,
                "base-meeting" => DeepgramTranscriberModel.BaseMeeting,
                "base-phonecall" => DeepgramTranscriberModel.BasePhonecall,
                "base-video" => DeepgramTranscriberModel.BaseVideo,
                "base-voicemail" => DeepgramTranscriberModel.BaseVoicemail,
                "enhanced" => DeepgramTranscriberModel.Enhanced,
                "enhanced-finance" => DeepgramTranscriberModel.EnhancedFinance,
                "enhanced-general" => DeepgramTranscriberModel.EnhancedGeneral,
                "enhanced-meeting" => DeepgramTranscriberModel.EnhancedMeeting,
                "enhanced-phonecall" => DeepgramTranscriberModel.EnhancedPhonecall,
                "flux-general-en" => DeepgramTranscriberModel.FluxGeneralEn,
                "nova" => DeepgramTranscriberModel.Nova,
                "nova-2" => DeepgramTranscriberModel.Nova2,
                "nova-2-automotive" => DeepgramTranscriberModel.Nova2Automotive,
                "nova-2-conversationalai" => DeepgramTranscriberModel.Nova2Conversationalai,
                "nova-2-drivethru" => DeepgramTranscriberModel.Nova2Drivethru,
                "nova-2-finance" => DeepgramTranscriberModel.Nova2Finance,
                "nova-2-general" => DeepgramTranscriberModel.Nova2General,
                "nova-2-medical" => DeepgramTranscriberModel.Nova2Medical,
                "nova-2-meeting" => DeepgramTranscriberModel.Nova2Meeting,
                "nova-2-phonecall" => DeepgramTranscriberModel.Nova2Phonecall,
                "nova-2-video" => DeepgramTranscriberModel.Nova2Video,
                "nova-2-voicemail" => DeepgramTranscriberModel.Nova2Voicemail,
                "nova-3" => DeepgramTranscriberModel.Nova3,
                "nova-3-general" => DeepgramTranscriberModel.Nova3General,
                "nova-3-medical" => DeepgramTranscriberModel.Nova3Medical,
                "nova-general" => DeepgramTranscriberModel.NovaGeneral,
                "nova-medical" => DeepgramTranscriberModel.NovaMedical,
                "nova-phonecall" => DeepgramTranscriberModel.NovaPhonecall,
                "whisper" => DeepgramTranscriberModel.Whisper,
                _ => null,
            };
        }
    }
}