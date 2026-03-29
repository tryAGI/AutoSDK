//HintName: G.Models.VisionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for image analysis.
    /// </summary>
    public enum VisionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        PalmyraVision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionRequestModel value)
        {
            return value switch
            {
                VisionRequestModel.PalmyraVision => "palmyra-vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "palmyra-vision" => VisionRequestModel.PalmyraVision,
                _ => null,
            };
        }
    }
}