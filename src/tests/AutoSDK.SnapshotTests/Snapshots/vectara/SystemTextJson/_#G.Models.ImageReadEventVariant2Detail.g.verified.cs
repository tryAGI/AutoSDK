//HintName: G.Models.ImageReadEventVariant2Detail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detail level for image processing.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum ImageReadEventVariant2Detail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageReadEventVariant2DetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageReadEventVariant2Detail value)
        {
            return value switch
            {
                ImageReadEventVariant2Detail.Auto => "auto",
                ImageReadEventVariant2Detail.Low => "low",
                ImageReadEventVariant2Detail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageReadEventVariant2Detail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageReadEventVariant2Detail.Auto,
                "low" => ImageReadEventVariant2Detail.Low,
                "high" => ImageReadEventVariant2Detail.High,
                _ => null,
            };
        }
    }
}