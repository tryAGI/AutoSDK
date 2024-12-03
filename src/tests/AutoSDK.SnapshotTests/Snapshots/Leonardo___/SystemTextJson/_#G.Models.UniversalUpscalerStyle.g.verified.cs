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
        GENERAL,
        /// <summary>
        /// 
        /// </summary>
        CINEMATIC,
        /// <summary>
        /// 
        /// </summary>
        x2DART_ILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        CGART_GAMEASSETS,
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
                UniversalUpscalerStyle.GENERAL => "GENERAL",
                UniversalUpscalerStyle.CINEMATIC => "CINEMATIC",
                UniversalUpscalerStyle.x2DART_ILLUSTRATION => "2D ART & ILLUSTRATION",
                UniversalUpscalerStyle.CGART_GAMEASSETS => "CG ART & GAME ASSETS",
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
                "GENERAL" => UniversalUpscalerStyle.GENERAL,
                "CINEMATIC" => UniversalUpscalerStyle.CINEMATIC,
                "2D ART & ILLUSTRATION" => UniversalUpscalerStyle.x2DART_ILLUSTRATION,
                "CG ART & GAME ASSETS" => UniversalUpscalerStyle.CGART_GAMEASSETS,
                _ => null,
            };
        }
    }
}