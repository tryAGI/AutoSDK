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
        AUTO,
        /// <summary>
        /// 
        /// </summary>
        GENERAL,
        /// <summary>
        /// 
        /// </summary>
        REALISTIC,
        /// <summary>
        /// 
        /// </summary>
        DESIGN,
        /// <summary>
        /// 
        /// </summary>
        RENDER3D,
        /// <summary>
        /// 
        /// </summary>
        ANIME,
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
                StyleType.AUTO => "AUTO",
                StyleType.GENERAL => "GENERAL",
                StyleType.REALISTIC => "REALISTIC",
                StyleType.DESIGN => "DESIGN",
                StyleType.RENDER3D => "RENDER_3D",
                StyleType.ANIME => "ANIME",
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
                "AUTO" => StyleType.AUTO,
                "GENERAL" => StyleType.GENERAL,
                "REALISTIC" => StyleType.REALISTIC,
                "DESIGN" => StyleType.DESIGN,
                "RENDER_3D" => StyleType.RENDER3D,
                "ANIME" => StyleType.ANIME,
                _ => null,
            };
        }
    }
}