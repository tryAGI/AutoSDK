//HintName: G.Models.ImageReadToolParametersDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detail level for image processing.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum ImageReadToolParametersDetail
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
    public static class ImageReadToolParametersDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageReadToolParametersDetail value)
        {
            return value switch
            {
                ImageReadToolParametersDetail.Auto => "auto",
                ImageReadToolParametersDetail.Low => "low",
                ImageReadToolParametersDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageReadToolParametersDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageReadToolParametersDetail.Auto,
                "low" => ImageReadToolParametersDetail.Low,
                "high" => ImageReadToolParametersDetail.High,
                _ => null,
            };
        }
    }
}