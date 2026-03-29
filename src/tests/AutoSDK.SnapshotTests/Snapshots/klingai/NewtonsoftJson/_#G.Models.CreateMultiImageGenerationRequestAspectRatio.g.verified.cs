//HintName: G.Models.CreateMultiImageGenerationRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the output image.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateMultiImageGenerationRequestAspectRatio
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
    public static class CreateMultiImageGenerationRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMultiImageGenerationRequestAspectRatio value)
        {
            return value switch
            {
                CreateMultiImageGenerationRequestAspectRatio.x16_9 => "16:9",
                CreateMultiImageGenerationRequestAspectRatio.x1_1 => "1:1",
                CreateMultiImageGenerationRequestAspectRatio.x2_3 => "2:3",
                CreateMultiImageGenerationRequestAspectRatio.x3_2 => "3:2",
                CreateMultiImageGenerationRequestAspectRatio.x3_4 => "3:4",
                CreateMultiImageGenerationRequestAspectRatio.x4_3 => "4:3",
                CreateMultiImageGenerationRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMultiImageGenerationRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateMultiImageGenerationRequestAspectRatio.x16_9,
                "1:1" => CreateMultiImageGenerationRequestAspectRatio.x1_1,
                "2:3" => CreateMultiImageGenerationRequestAspectRatio.x2_3,
                "3:2" => CreateMultiImageGenerationRequestAspectRatio.x3_2,
                "3:4" => CreateMultiImageGenerationRequestAspectRatio.x3_4,
                "4:3" => CreateMultiImageGenerationRequestAspectRatio.x4_3,
                "9:16" => CreateMultiImageGenerationRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}