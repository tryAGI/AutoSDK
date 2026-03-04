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
        General,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        x2dArt_Illustration,
        /// <summary>
        /// 
        /// </summary>
        CgArt_GameAssets,
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
                UniversalUpscalerStyle.General => "GENERAL",
                UniversalUpscalerStyle.Cinematic => "CINEMATIC",
                UniversalUpscalerStyle.x2dArt_Illustration => "2D ART & ILLUSTRATION",
                UniversalUpscalerStyle.CgArt_GameAssets => "CG ART & GAME ASSETS",
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
                "GENERAL" => UniversalUpscalerStyle.General,
                "CINEMATIC" => UniversalUpscalerStyle.Cinematic,
                "2D ART & ILLUSTRATION" => UniversalUpscalerStyle.x2dArt_Illustration,
                "CG ART & GAME ASSETS" => UniversalUpscalerStyle.CgArt_GameAssets,
                _ => null,
            };
        }
    }
}