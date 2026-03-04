//HintName: G.Models.StyleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
    /// Example: REALISTIC
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StyleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUTO")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERAL")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REALISTIC")]
        Realistic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESIGN")]
        Design,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RENDER_3D")]
        Render3d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANIME")]
        Anime,
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
                StyleType.Auto => "AUTO",
                StyleType.General => "GENERAL",
                StyleType.Realistic => "REALISTIC",
                StyleType.Design => "DESIGN",
                StyleType.Render3d => "RENDER_3D",
                StyleType.Anime => "ANIME",
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
                "AUTO" => StyleType.Auto,
                "GENERAL" => StyleType.General,
                "REALISTIC" => StyleType.Realistic,
                "DESIGN" => StyleType.Design,
                "RENDER_3D" => StyleType.Render3d,
                "ANIME" => StyleType.Anime,
                _ => null,
            };
        }
    }
}