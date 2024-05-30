//HintName: G.Models.CreateImageRequestQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.
    /// <br/>Default Value: standard
    /// <br/>Example: standard
    /// </summary>
    public enum CreateImageRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Hd,
    }

    public static class CreateImageRequestQualityExtensions
    {
        public static string ToValueString(this CreateImageRequestQuality value)
        {
            return value switch
            {
                CreateImageRequestQuality.Standard => "standard",
                CreateImageRequestQuality.Hd => "hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestQuality ToEnum(string value)
        {
            return value switch
            {
                "standard" => CreateImageRequestQuality.Standard,
                "hd" => CreateImageRequestQuality.Hd,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestQuality ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageRequestQuality.Standard,
                1 => CreateImageRequestQuality.Hd,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}