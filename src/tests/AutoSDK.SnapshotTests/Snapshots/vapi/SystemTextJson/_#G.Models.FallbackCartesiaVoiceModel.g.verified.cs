//HintName: G.Models.FallbackCartesiaVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. This is optional and will default to the correct model for the voiceId.<br/>
    /// Example: sonic-english
    /// </summary>
    public enum FallbackCartesiaVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sonic,
        /// <summary>
        /// 
        /// </summary>
        Sonic2,
        /// <summary>
        /// 
        /// </summary>
        Sonic220250611,
        /// <summary>
        /// 
        /// </summary>
        Sonic3,
        /// <summary>
        /// 
        /// </summary>
        Sonic320251027,
        /// <summary>
        /// 
        /// </summary>
        Sonic320260112,
        /// <summary>
        /// 
        /// </summary>
        SonicEnglish,
        /// <summary>
        /// 
        /// </summary>
        SonicMultilingual,
        /// <summary>
        /// 
        /// </summary>
        SonicPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCartesiaVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCartesiaVoiceModel value)
        {
            return value switch
            {
                FallbackCartesiaVoiceModel.Sonic => "sonic",
                FallbackCartesiaVoiceModel.Sonic2 => "sonic-2",
                FallbackCartesiaVoiceModel.Sonic220250611 => "sonic-2-2025-06-11",
                FallbackCartesiaVoiceModel.Sonic3 => "sonic-3",
                FallbackCartesiaVoiceModel.Sonic320251027 => "sonic-3-2025-10-27",
                FallbackCartesiaVoiceModel.Sonic320260112 => "sonic-3-2026-01-12",
                FallbackCartesiaVoiceModel.SonicEnglish => "sonic-english",
                FallbackCartesiaVoiceModel.SonicMultilingual => "sonic-multilingual",
                FallbackCartesiaVoiceModel.SonicPreview => "sonic-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCartesiaVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "sonic" => FallbackCartesiaVoiceModel.Sonic,
                "sonic-2" => FallbackCartesiaVoiceModel.Sonic2,
                "sonic-2-2025-06-11" => FallbackCartesiaVoiceModel.Sonic220250611,
                "sonic-3" => FallbackCartesiaVoiceModel.Sonic3,
                "sonic-3-2025-10-27" => FallbackCartesiaVoiceModel.Sonic320251027,
                "sonic-3-2026-01-12" => FallbackCartesiaVoiceModel.Sonic320260112,
                "sonic-english" => FallbackCartesiaVoiceModel.SonicEnglish,
                "sonic-multilingual" => FallbackCartesiaVoiceModel.SonicMultilingual,
                "sonic-preview" => FallbackCartesiaVoiceModel.SonicPreview,
                _ => null,
            };
        }
    }
}