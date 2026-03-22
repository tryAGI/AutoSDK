//HintName: G.Models.AspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Cannot be used in conjunction with resolution) The aspect ratio to use for image generation, which determines the image's resolution. Defaults to ASPECT_1_1.<br/>
    /// Example: ASPECT_10_16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_10_16")]
        Aspect1016,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_16_10")]
        Aspect1610,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_16_9")]
        Aspect169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_1_1")]
        Aspect11,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_1_3")]
        Aspect13,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_2_3")]
        Aspect23,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_1")]
        Aspect31,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_2")]
        Aspect32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_4")]
        Aspect34,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_4_3")]
        Aspect43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_9_16")]
        Aspect916,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.Aspect1016 => "ASPECT_10_16",
                AspectRatio.Aspect1610 => "ASPECT_16_10",
                AspectRatio.Aspect169 => "ASPECT_16_9",
                AspectRatio.Aspect11 => "ASPECT_1_1",
                AspectRatio.Aspect13 => "ASPECT_1_3",
                AspectRatio.Aspect23 => "ASPECT_2_3",
                AspectRatio.Aspect31 => "ASPECT_3_1",
                AspectRatio.Aspect32 => "ASPECT_3_2",
                AspectRatio.Aspect34 => "ASPECT_3_4",
                AspectRatio.Aspect43 => "ASPECT_4_3",
                AspectRatio.Aspect916 => "ASPECT_9_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "ASPECT_10_16" => AspectRatio.Aspect1016,
                "ASPECT_16_10" => AspectRatio.Aspect1610,
                "ASPECT_16_9" => AspectRatio.Aspect169,
                "ASPECT_1_1" => AspectRatio.Aspect11,
                "ASPECT_1_3" => AspectRatio.Aspect13,
                "ASPECT_2_3" => AspectRatio.Aspect23,
                "ASPECT_3_1" => AspectRatio.Aspect31,
                "ASPECT_3_2" => AspectRatio.Aspect32,
                "ASPECT_3_4" => AspectRatio.Aspect34,
                "ASPECT_4_3" => AspectRatio.Aspect43,
                "ASPECT_9_16" => AspectRatio.Aspect916,
                _ => null,
            };
        }
    }
}