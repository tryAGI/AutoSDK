//HintName: G.Models.StyleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
    /// Example: REALISTIC
    /// </summary>
    public enum StyleType
    {
        /// <summary>
        /// 
        /// </summary>
        Anime,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Design,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Realistic,
        /// <summary>
        /// 
        /// </summary>
        Render3d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleType value)
        {
            return value switch
            {
                StyleType.Anime => "ANIME",
                StyleType.Auto => "AUTO",
                StyleType.Design => "DESIGN",
                StyleType.General => "GENERAL",
                StyleType.Realistic => "REALISTIC",
                StyleType.Render3d => "RENDER_3D",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleType? ToEnum(string value)
        {
            return value switch
            {
                "ANIME" => StyleType.Anime,
                "AUTO" => StyleType.Auto,
                "DESIGN" => StyleType.Design,
                "GENERAL" => StyleType.General,
                "REALISTIC" => StyleType.Realistic,
                "RENDER_3D" => StyleType.Render3d,
                _ => null,
            };
        }
    }
}