//HintName: G.Models.CartesiaVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. This is optional and will default to the correct model for the voiceId.<br/>
    /// Example: sonic-english
    /// </summary>
    public enum CartesiaVoiceModel
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
    public static class CartesiaVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaVoiceModel value)
        {
            return value switch
            {
                CartesiaVoiceModel.Sonic => "sonic",
                CartesiaVoiceModel.Sonic2 => "sonic-2",
                CartesiaVoiceModel.Sonic220250611 => "sonic-2-2025-06-11",
                CartesiaVoiceModel.Sonic3 => "sonic-3",
                CartesiaVoiceModel.Sonic320251027 => "sonic-3-2025-10-27",
                CartesiaVoiceModel.Sonic320260112 => "sonic-3-2026-01-12",
                CartesiaVoiceModel.SonicEnglish => "sonic-english",
                CartesiaVoiceModel.SonicMultilingual => "sonic-multilingual",
                CartesiaVoiceModel.SonicPreview => "sonic-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "sonic" => CartesiaVoiceModel.Sonic,
                "sonic-2" => CartesiaVoiceModel.Sonic2,
                "sonic-2-2025-06-11" => CartesiaVoiceModel.Sonic220250611,
                "sonic-3" => CartesiaVoiceModel.Sonic3,
                "sonic-3-2025-10-27" => CartesiaVoiceModel.Sonic320251027,
                "sonic-3-2026-01-12" => CartesiaVoiceModel.Sonic320260112,
                "sonic-english" => CartesiaVoiceModel.SonicEnglish,
                "sonic-multilingual" => CartesiaVoiceModel.SonicMultilingual,
                "sonic-preview" => CartesiaVoiceModel.SonicPreview,
                _ => null,
            };
        }
    }
}