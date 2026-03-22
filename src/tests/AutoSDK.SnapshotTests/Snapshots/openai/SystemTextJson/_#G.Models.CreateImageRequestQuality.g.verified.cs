//HintName: G.Models.CreateImageRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. <br/>
    /// - `auto` (default value) will automatically select the best quality for the given model.<br/>
    /// - `high`, `medium` and `low` are supported for `gpt-image-1`.<br/>
    /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
    /// - `standard` is the only option for `dall-e-2`.<br/>
    /// Default Value: auto<br/>
    /// Example: medium
    /// </summary>
    public enum CreateImageRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Hd,
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
    public static class CreateImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestQuality value)
        {
            return value switch
            {
                CreateImageRequestQuality.Auto => "auto",
                CreateImageRequestQuality.Hd => "hd",
                CreateImageRequestQuality.High => "high",
                CreateImageRequestQuality.Low => "low",
                CreateImageRequestQuality.Medium => "medium",
                CreateImageRequestQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageRequestQuality.Auto,
                "hd" => CreateImageRequestQuality.Hd,
                "high" => CreateImageRequestQuality.High,
                "low" => CreateImageRequestQuality.Low,
                "medium" => CreateImageRequestQuality.Medium,
                "standard" => CreateImageRequestQuality.Standard,
                _ => null,
            };
        }
    }
}