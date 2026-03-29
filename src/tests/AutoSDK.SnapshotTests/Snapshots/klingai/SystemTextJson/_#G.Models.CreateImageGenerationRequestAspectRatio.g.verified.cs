//HintName: G.Models.CreateImageGenerationRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the output image.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum CreateImageGenerationRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
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