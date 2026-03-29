//HintName: G.Models.CreateImageGenerationRequestResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resolution of the output image.<br/>
    /// Default Value: 1k
    /// </summary>
    public enum CreateImageGenerationRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageGenerationRequestResolution value)
        {
            return value switch
            {
                CreateImageGenerationRequestResolution.x1k => "1k",
                CreateImageGenerationRequestResolution.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageGenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => CreateImageGenerationRequestResolution.x1k,
                "2k" => CreateImageGenerationRequestResolution.x2k,
                _ => null,
            };
        }
    }
}