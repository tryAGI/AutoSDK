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
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hd")]
        Hd,
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
    public static class CreateImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestQuality value)
        {
            return value switch
            {
                CreateImageRequestQuality.Standard => "standard",
                CreateImageRequestQuality.Hd => "hd",
                CreateImageRequestQuality.Low => "low",
                CreateImageRequestQuality.Medium => "medium",
                CreateImageRequestQuality.High => "high",
                CreateImageRequestQuality.Auto => "auto",
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
                "standard" => CreateImageRequestQuality.Standard,
                "hd" => CreateImageRequestQuality.Hd,
                "low" => CreateImageRequestQuality.Low,
                "medium" => CreateImageRequestQuality.Medium,
                "high" => CreateImageRequestQuality.High,
                "auto" => CreateImageRequestQuality.Auto,
                _ => null,
            };
        }
    }
}