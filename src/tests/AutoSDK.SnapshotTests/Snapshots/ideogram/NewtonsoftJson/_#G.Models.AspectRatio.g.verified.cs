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
        ASPECT1016,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_16_10")]
        ASPECT1610,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_9_16")]
        ASPECT916,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_16_9")]
        ASPECT169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_2")]
        ASPECT32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_2_3")]
        ASPECT23,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_4_3")]
        ASPECT43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_4")]
        ASPECT34,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_1_1")]
        ASPECT11,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_1_3")]
        ASPECT13,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASPECT_3_1")]
        ASPECT31,
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
                AspectRatio.ASPECT1016 => "ASPECT_10_16",
                AspectRatio.ASPECT1610 => "ASPECT_16_10",
                AspectRatio.ASPECT916 => "ASPECT_9_16",
                AspectRatio.ASPECT169 => "ASPECT_16_9",
                AspectRatio.ASPECT32 => "ASPECT_3_2",
                AspectRatio.ASPECT23 => "ASPECT_2_3",
                AspectRatio.ASPECT43 => "ASPECT_4_3",
                AspectRatio.ASPECT34 => "ASPECT_3_4",
                AspectRatio.ASPECT11 => "ASPECT_1_1",
                AspectRatio.ASPECT13 => "ASPECT_1_3",
                AspectRatio.ASPECT31 => "ASPECT_3_1",
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
                "ASPECT_10_16" => AspectRatio.ASPECT1016,
                "ASPECT_16_10" => AspectRatio.ASPECT1610,
                "ASPECT_9_16" => AspectRatio.ASPECT916,
                "ASPECT_16_9" => AspectRatio.ASPECT169,
                "ASPECT_3_2" => AspectRatio.ASPECT32,
                "ASPECT_2_3" => AspectRatio.ASPECT23,
                "ASPECT_4_3" => AspectRatio.ASPECT43,
                "ASPECT_3_4" => AspectRatio.ASPECT34,
                "ASPECT_1_1" => AspectRatio.ASPECT11,
                "ASPECT_1_3" => AspectRatio.ASPECT13,
                "ASPECT_3_1" => AspectRatio.ASPECT31,
                _ => null,
            };
        }
    }
}