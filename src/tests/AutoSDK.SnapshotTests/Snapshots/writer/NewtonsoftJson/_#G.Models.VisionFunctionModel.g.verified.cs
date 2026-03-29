//HintName: G.Models.VisionFunctionModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for image analysis.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VisionFunctionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="palmyra-vision")]
        PalmyraVision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionFunctionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionFunctionModel value)
        {
            return value switch
            {
                VisionFunctionModel.PalmyraVision => "palmyra-vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionFunctionModel? ToEnum(string value)
        {
            return value switch
            {
                "palmyra-vision" => VisionFunctionModel.PalmyraVision,
                _ => null,
            };
        }
    }
}