//HintName: G.Models.DeepgramTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeepgramTranscriberModel
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