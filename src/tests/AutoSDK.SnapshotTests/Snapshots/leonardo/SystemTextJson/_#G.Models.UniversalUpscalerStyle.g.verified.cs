//HintName: G.Models.UniversalUpscalerStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style to upscale images using universal upscaler with.<br/>
    /// Default Value: GENERAL
    /// </summary>
    public enum UniversalUpscalerStyle
    {
        /// <summary>
        /// 
        /// </summary>
        x2dArt_Illustration,
        /// <summary>
        /// 
        /// </summary>
        CgArt_GameAssets,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        General,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UniversalUpscalerStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UniversalUpscalerStyle value)
        {
            return value switch
            {
                UniversalUpscalerStyle.x2dArt_Illustration => "2D ART & ILLUSTRATION",
                UniversalUpscalerStyle.CgArt_GameAssets => "CG ART & GAME ASSETS",
                UniversalUpscalerStyle.Cinematic => "CINEMATIC",
                UniversalUpscalerStyle.General => "GENERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UniversalUpscalerStyle? ToEnum(string value)
        {
            return value switch
            {
                "2D ART & ILLUSTRATION" => UniversalUpscalerStyle.x2dArt_Illustration,
                "CG ART & GAME ASSETS" => UniversalUpscalerStyle.CgArt_GameAssets,
                "CINEMATIC" => UniversalUpscalerStyle.Cinematic,
                "GENERAL" => UniversalUpscalerStyle.General,
                _ => null,
            };
        }
    }
}