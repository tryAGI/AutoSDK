//HintName: G.Models.CreateImageVariationRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.
    /// <br/>Default Value: 1024x1024
    /// <br/>Example: 1024x1024
    /// </summary>
    public enum CreateImageVariationRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        _256x256,
        /// <summary>
        /// 
        /// </summary>
        _512x512,
        /// <summary>
        /// 
        /// </summary>
        _1024x1024,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageVariationRequestSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageVariationRequestSize value)
        {
            return value switch
            {
                CreateImageVariationRequestSize._256x256 => "256x256",
                CreateImageVariationRequestSize._512x512 => "512x512",
                CreateImageVariationRequestSize._1024x1024 => "1024x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageVariationRequestSize ToEnum(string value)
        {
            return value switch
            {
                "256x256" => CreateImageVariationRequestSize._256x256,
                "512x512" => CreateImageVariationRequestSize._512x512,
                "1024x1024" => CreateImageVariationRequestSize._1024x1024,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}