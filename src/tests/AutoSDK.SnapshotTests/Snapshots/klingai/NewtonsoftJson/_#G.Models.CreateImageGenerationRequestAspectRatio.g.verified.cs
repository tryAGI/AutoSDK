//HintName: G.Models.CreateImageGenerationRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the output image.<br/>
    /// Default Value: 16:9
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageGenerationRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16:9")]
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1:1")]
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2:3")]
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3:2")]
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3:4")]
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4:3")]
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="9:16")]
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageGenerationRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageGenerationRequestAspectRatio value)
        {
            return value switch
            {
                CreateImageGenerationRequestAspectRatio.x16_9 => "16:9",
                CreateImageGenerationRequestAspectRatio.x1_1 => "1:1",
                CreateImageGenerationRequestAspectRatio.x2_3 => "2:3",
                CreateImageGenerationRequestAspectRatio.x3_2 => "3:2",
                CreateImageGenerationRequestAspectRatio.x3_4 => "3:4",
                CreateImageGenerationRequestAspectRatio.x4_3 => "4:3",
                CreateImageGenerationRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageGenerationRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateImageGenerationRequestAspectRatio.x16_9,
                "1:1" => CreateImageGenerationRequestAspectRatio.x1_1,
                "2:3" => CreateImageGenerationRequestAspectRatio.x2_3,
                "3:2" => CreateImageGenerationRequestAspectRatio.x3_2,
                "3:4" => CreateImageGenerationRequestAspectRatio.x3_4,
                "4:3" => CreateImageGenerationRequestAspectRatio.x4_3,
                "9:16" => CreateImageGenerationRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}