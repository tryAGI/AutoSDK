//HintName: G.Models.ImageGenerationServerToolInputFidelity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenerationServerToolInputFidelity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolInputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolInputFidelity value)
        {
            return value switch
            {
                ImageGenerationServerToolInputFidelity.High => "high",
                ImageGenerationServerToolInputFidelity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolInputFidelity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ImageGenerationServerToolInputFidelity.High,
                "low" => ImageGenerationServerToolInputFidelity.Low,
                _ => null,
            };
        }
    }
}