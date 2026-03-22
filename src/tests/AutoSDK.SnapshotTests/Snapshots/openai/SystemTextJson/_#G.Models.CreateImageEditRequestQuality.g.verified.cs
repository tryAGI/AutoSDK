//HintName: G.Models.CreateImageEditRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. `high`, `medium` and `low` are only supported for `gpt-image-1`. `dall-e-2` only supports `standard` quality. Defaults to `auto`.<br/>
    /// Default Value: auto<br/>
    /// Example: high
    /// </summary>
    public enum CreateImageEditRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestQuality value)
        {
            return value switch
            {
                CreateImageEditRequestQuality.Auto => "auto",
                CreateImageEditRequestQuality.High => "high",
                CreateImageEditRequestQuality.Low => "low",
                CreateImageEditRequestQuality.Medium => "medium",
                CreateImageEditRequestQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageEditRequestQuality.Auto,
                "high" => CreateImageEditRequestQuality.High,
                "low" => CreateImageEditRequestQuality.Low,
                "medium" => CreateImageEditRequestQuality.Medium,
                "standard" => CreateImageEditRequestQuality.Standard,
                _ => null,
            };
        }
    }
}