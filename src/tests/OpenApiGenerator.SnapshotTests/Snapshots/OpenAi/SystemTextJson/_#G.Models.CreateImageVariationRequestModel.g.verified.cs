//HintName: G.Models.CreateImageVariationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageVariationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DallE2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageVariationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageVariationRequestModel value)
        {
            return value switch
            {
                CreateImageVariationRequestModel.DallE2 => "dall-e-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageVariationRequestModel ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageVariationRequestModel.DallE2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}