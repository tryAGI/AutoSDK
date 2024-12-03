//HintName: G.Models.CreateImageRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.<br/>
    /// Default Value: standard<br/>
    /// Example: standard
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
                _ => null,
            };
        }
    }
}