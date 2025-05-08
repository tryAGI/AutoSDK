//HintName: G.Models.CreateImageEditRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. `high`, `medium` and `low` are only supported for `gpt-image-1`. `dall-e-2` only supports `standard` quality. Defaults to `auto`.<br/>
    /// Default Value: auto<br/>
    /// Example: high
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageEditRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
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
                CreateImageEditRequestQuality.Standard => "standard",
                CreateImageEditRequestQuality.Low => "low",
                CreateImageEditRequestQuality.Medium => "medium",
                CreateImageEditRequestQuality.High => "high",
                CreateImageEditRequestQuality.Auto => "auto",
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
                "standard" => CreateImageEditRequestQuality.Standard,
                "low" => CreateImageEditRequestQuality.Low,
                "medium" => CreateImageEditRequestQuality.Medium,
                "high" => CreateImageEditRequestQuality.High,
                "auto" => CreateImageEditRequestQuality.Auto,
                _ => null,
            };
        }
    }
}