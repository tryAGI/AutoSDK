//HintName: G.Models.FallbackDeepgramTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackDeepgramTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base")]
        Base,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-conversationalai")]
        BaseConversationalai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-finance")]
        BaseFinance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-general")]
        BaseGeneral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-meeting")]
        BaseMeeting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-phonecall")]
        BasePhonecall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-video")]
        BaseVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base-voicemail")]
        BaseVoicemail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced")]
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced-finance")]
        EnhancedFinance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced-general")]
        EnhancedGeneral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced-meeting")]
        EnhancedMeeting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced-phonecall")]
        EnhancedPhonecall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flux-general-en")]
        FluxGeneralEn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova")]
        Nova,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2")]
        Nova2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-automotive")]
        Nova2Automotive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-conversationalai")]
        Nova2Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-drivethru")]
        Nova2Drivethru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-finance")]
        Nova2Finance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-general")]
        Nova2General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-medical")]
        Nova2Medical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-meeting")]
        Nova2Meeting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-phonecall")]
        Nova2Phonecall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-video")]
        Nova2Video,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-2-voicemail")]
        Nova2Voicemail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-3")]
        Nova3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-3-general")]
        Nova3General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-3-medical")]
        Nova3Medical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-general")]
        NovaGeneral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-medical")]
        NovaMedical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova-phonecall")]
        NovaPhonecall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper")]
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